using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCrypter
{
    public partial class Main : Form
    {
        string decryptInput = "";
        string decryptOutput = "";

        string encryptInput = "";
        string encryptOutput = "";
        string encryptPayload = "";

        public Main()
        {
            InitializeComponent();
            lblDecryptInfo.Text = "";
            lblEncryptInfo.Text = "";
        }


        //
        //  File Dialog Stuff
        //

        // Decrypt

        void UpdateDecryptButtons()
        {
            if (decryptInput != "" && decryptOutput != "")
                cmdDecrypt.Enabled = true;
            else
                cmdDecrypt.Enabled = false;
        }

        private void cmdDecryptOpen_Click(object sender, EventArgs e)
        {
            ofdOpen = new OpenFileDialog();
            ofdOpen.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png";
            if(ofdOpen.ShowDialog() == DialogResult.OK)
            {
                decryptInput = ofdOpen.FileName;
                UpdateDecryptButtons();
            }
        }

        private void cmdDecryptSave_Click(object sender, EventArgs e)
        {
            sfdSave = new SaveFileDialog();
            sfdSave.Filter = "All files|*.*";
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                decryptOutput = sfdSave.FileName;
                UpdateDecryptButtons();
            }
            UpdateDecryptButtons();
        }

        // Encrypt

        void UpdateEncryptButtons()
        {
            if (encryptInput != "" && encryptOutput != "" && encryptPayload != "")
                cmdEncrypt.Enabled = true;
            else
                cmdEncrypt.Enabled = false;
        }

        private void cmdEncryptOpen_Click(object sender, EventArgs e)
        {
            ofdOpen = new OpenFileDialog();
            ofdOpen.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png";
            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                encryptInput = ofdOpen.FileName;
                UpdateDecryptButtons();
            }
            UpdateEncryptButtons();
        }

        private void cmdEncryptSave_Click(object sender, EventArgs e)
        {
            sfdSave = new SaveFileDialog();
            sfdSave.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png";
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                encryptOutput = sfdSave.FileName;
                UpdateDecryptButtons();
            }
            UpdateEncryptButtons();
        }

        private void cmdEncryptPayload_Click(object sender, EventArgs e)
        {
            ofdOpen = new OpenFileDialog();
            ofdOpen.Filter = "All files|*.*";
            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                encryptPayload = ofdOpen.FileName;
                UpdateDecryptButtons();
            }
            UpdateEncryptButtons();
        }

        //
        //  Crypter Methods
        //

        // Decrypt

        private async void cmdDecrypt_Click(object sender, EventArgs e)
        {
            ImageCrypter img = new ImageCrypter(decryptInput, decryptOutput);
            Task<int> t = Task.Factory.StartNew(() => img.Decrypt((int)numDecryptBits.Value));

            Invoke((MethodInvoker)delegate
            {
                lblDecryptInfo.Text = "Running.";
            });

            await t;
            if (t.Result >= 0)
            {
                MessageBox.Show("Done!\nEllapsed seconds: " + t.Result / 1000.0);

                Invoke((MethodInvoker)delegate
                {
                    lblDecryptInfo.Text = "Done.";
                });
            }
        }

        // Encrypt

        private async void cmdEncrypt_Click(object sender, EventArgs e)
        {
            ImageCrypter img = new ImageCrypter(encryptInput, encryptOutput, encryptPayload);
            Task<int> t = Task.Factory.StartNew(() => img.Encrypt((int)numEncryptBits.Value));

            Invoke((MethodInvoker)delegate
            {
                lblEncryptInfo.Text = "Running.";
            });

            await t;
            if (t.Result >= 0)
            {
                MessageBox.Show("Done!\nEllapsed seconds: " + t.Result / 1000.0);

                Invoke((MethodInvoker)delegate
                {
                    lblEncryptInfo.Text = "Done.";
                });
            }
        }
    }
}
