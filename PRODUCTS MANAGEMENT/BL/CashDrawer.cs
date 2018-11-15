using System.Runtime.InteropServices;
using System.Text;
namespace PRODUCTS_MANAGEMENT.BL
{
    class USB
    {
        [DllImport("cd722dusb.dll", 
        CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern bool opencd722usb();
        [DllImport("cd722dusb.dll",
            CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
         public static extern int writecd722usb(ref byte dataoutput, int Length);
        [DllImport("cd722dusb.dll", 
        CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern int readcd722usb(ref byte DataInput, int size);
         [DllImport("cd722dusb.dll", 
         CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern bool closecd722usb();
        private bool m_USB_is_Open = false;
        private bool m_Result = false;
        public USB()
        {
        }

        public void OpenPort()
        {
            if (m_USB_is_Open)
            {
                throw new System.IO.IOException("USB is already open");
             }
            m_Result = opencd722usb();
            if (m_Result)
            {
                m_USB_is_Open = true;
            }
            else
            {
                throw new System.IO.IOException("Unable to open USB");
            }
        }

        public void ClosePort()
         {
            if (!m_USB_is_Open)
            {
                throw new System.IO.IOException("USB is already closed");
            }
            m_Result = closecd722usb();
            if (m_Result)
            {
                m_USB_is_Open = false;
            }
             else
            {
                throw new System.IO.IOException("Unable to close USB");
            }
        }

        public void WritePort(string DataOutput)
        {
            System.Text.Encoding Encoding = System.Text.Encoding.UTF8;
            byte[] byteOutput = Encoding.GetBytes(DataOutput);
            int Result = writecd722usb(ref byteOutput[0], byteOutput.Length);
        }

        public string ReadPort()
        {
            System.Text.Encoding Encoding = System.Text.Encoding.UTF8;
            byte[] readBuffer = new byte[2049];
            int readLength = 0;
            int Result = readcd722usb(ref readBuffer[0], readLength);
            return new string(Encoding.GetChars(readBuffer, 0, readLength));
         }
    }
    }
