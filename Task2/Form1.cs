using System.Drawing;

namespace Task2
{
    public partial class Form1 : Form
    {

        int sizeX = 16;
        int sizeY = 16;

        int bytesToRead = 64;

        bool[] bits;

        byte[] bytes;

        string path = null;

        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {

            if (IsReady() == false) return;

            bytes = GetBytes(path, bytesToRead);

            bits = Convert(bytes);

            Bitmap bitmap = new Bitmap(sizeX, sizeY);

            pictureBox1.Image = bitmap;

            pictureBox1.Size = new Size(sizeX * 2, sizeY * 2);

            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    bitmap.SetPixel(i, j, Color.Gray);
                }
            }

            int len = bits.Length;

            int x = 0, y = 0;

            for (int i = 0; i < len; i++)
            {
                if (x == sizeX)
                {
                    y++;
                    x = 0;

                    if (y == sizeY) break;

                }

                bitmap.SetPixel(x, y, bits[i] ? Color.White : Color.Black);


                x++;
            }

        }

        bool IsReady()
        {

            if (path == null)
            {
                MessageBox.Show("File not selected");
                return false;
            }

            if ((sizeX * sizeY) % 8 > 0)
            {
                MessageBox.Show("Size of the visualization area should be a multiple of 8");
                return false;
            }

            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            int old = sizeX;

            try
            {
                sizeX = int.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                sizeX = old;
                textBox1.Text = sizeX.ToString();
            }


        }
        private void button3_Click(object sender, EventArgs e)
        {
            StringWriter sw = new StringWriter();


            int len = bits.Length;

            int x = 0, y = 0;

            for (int i = 0; i < len; i++)
            {
                if (x == sizeX)
                {
                    y++;
                    x = 0;

                    sw.WriteLine();

                    if (y == sizeY) break;

                }

                sw.Write(bits[i] ? "1" : "0");

                x++;
            }

            sw = new StringWriter();

            len = bytes.Length;

            x = 0;
            y = 0;

            for (int i = 0; i < len; i++)
            {
                if (x == sizeX / 8)
                {
                    y++;
                    x = 0;

                    sw.WriteLine();

                    if (y == sizeY) break;

                }

                sw.Write(bytes[i] + " ");

                x++;
            }

            File.WriteAllText("outputbytes.txt", sw.ToString());

            MessageBox.Show($"saved output to files 'output.txt' and 'outputbytes.txt' in program folder");


        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int old = sizeY;

            try
            {
                sizeY = int.Parse(textBox2.Text);
            }
            catch (Exception)
            {
                sizeY = old;
                textBox2.Text = sizeY.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "All Files|*.*";
            openFileDialog1.Title = "Open a Text File";

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Read the content from the selected file
                path = openFileDialog1.FileName;
                string fileName = Path.GetFileName(path);

                bits = Convert(File.ReadAllBytes(path));

                label3.Text = $"selected file: {fileName}";

            }
        }
        byte[] GetBytes(string Path, int Number)
        {
            if (string.IsNullOrEmpty(Path) || !File.Exists(Path))
            {
                throw new FileNotFoundException("File not found.", Path);
            }

            byte[] bytes;

            using (FileStream fs = new FileStream(Path, FileMode.Open))
            {
                bytes = new byte[Number];
                int bytesRead = fs.Read(bytes, 0, Number);

                if (bytesRead < Number)
                {
                    Console.WriteLine($"Warning: Only {bytesRead} bytes were read.");
                }
            }

            return bytes;
        }
        static bool[] Convert(byte[] Array)
        {
            bool[] bitArray = new bool[Array.Length * 8]; // Each byte contains 8 bits

            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    bitArray[i * 8 + j] = (Array[i] & (1 << (7 - j))) != 0;
                }
            }

            return bitArray;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int old = bytesToRead;

            try
            {
                bytesToRead = int.Parse(textBox3.Text);
            }
            catch (Exception)
            {
                bytesToRead = old;
                textBox3.Text = bytesToRead.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
