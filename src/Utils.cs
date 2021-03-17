using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;
using System.Security.Cryptography;

namespace HighlightHelper {
  static class Utils {
    [System.Runtime.InteropServices.DllImport("gdi32.dll")]
    private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

    // private static PrivateFontCollection fonts = new PrivateFontCollection();
    // public static Font sarasa;

    /* public static void InitFont() {
      byte[] fontData = Properties.Resources.sarasa_ui_sc_semibold;
      IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
      System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
      uint dummy = 0;
      fonts.AddMemoryFont(fontPtr, Properties.Resources.sarasa_ui_sc_semibold.Length);
      AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.sarasa_ui_sc_semibold.Length, IntPtr.Zero, ref dummy);
      System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

      sarasa = new Font(fonts.Families[0], 11.0F);
    }
    public static void SetFont(Control root) {
      foreach (var i in GetAllControls(root)) {
        i.Font = sarasa;
      }
    } */

    public static IEnumerable<Control> GetAllControls(Control root) {
      Stack<Control> stack = new Stack<Control>();
      stack.Push(root);

      while (stack.Any()) {
        var nxt = stack.Pop();

        foreach (Control sub in nxt.Controls) {
          stack.Push(sub);
        }

        yield return nxt;
      }
    }


    public static void ShuffleList(List<string> list) {
      RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
      int n = list.Count;
      while (n > 1) {
        byte[] box = new byte[1];
        do provider.GetBytes(box);
        while (!(box[0] < n * (Byte.MaxValue / n)));
        int k = (box[0] % n);
        n--;
        string value = list[k];
        list[k] = list[n];
        list[n] = value;
      }
    }
  }
}
