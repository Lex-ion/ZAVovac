namespace ZAVovač
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TopMost = true;
        }

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        public void button1_Click(object sender, EventArgs e)
        {

            int interval = 75;
            int.TryParse(textBox1.Text, out interval);
            bool pozadu = checkBox1.Checked;

            if (interval < 0)
                interval = 0;

            string vstup = richTextBox1.Text;

            Cursor.Position = new Point(850, 850);
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);

            for (int i = 0; i < vstup.Length; i++)
            {

                Output.Send(vstup[i],interval);


    
                
            }

            if (pozadu)
            {
                SendKeys.Send("{Enter}");

                for (int i = vstup.Length - 1; i > -1; i--)
                {
                    Output.Send(vstup[i],interval);

                }
            }

        }

       
    }
}