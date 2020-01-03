
using ExaminationManagement.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

public class FontManager
{

    public Font MavenPro_Regular15;
    public Font MavenPro_Regular15_2;
    public Font MavenPro_Regular12;


    public FontManager()
    {
        MavenPro_Regular15 = new Font(LoadFont(Resources.MavenPro_Regular), 15f);
        MavenPro_Regular15_2 = new Font(LoadFont(Resources.MavenPro_Regular), 15f);
        MavenPro_Regular12 = new Font(LoadFont(Resources.MavenPro_Regular), 12f);  
    }

    private PrivateFontCollection privateFontCollection = new PrivateFontCollection();
    
    [DllImport("gdi32.dll")]
    private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pvd, [In] ref uint pcFonts);

    private FontFamily LoadFont(byte[] fontResource)
    {
        int dataLength = fontResource.Length;
        IntPtr fontPtr = Marshal.AllocCoTaskMem(dataLength);
        Marshal.Copy(fontResource, 0, fontPtr, dataLength);

        uint cFonts = 0;
        AddFontMemResourceEx(fontPtr, (uint)fontResource.Length, IntPtr.Zero, ref cFonts);
        privateFontCollection.AddMemoryFont(fontPtr, dataLength);

        return privateFontCollection.Families.Last();
    }
}
