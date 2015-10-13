﻿using System;
using System.Runtime.InteropServices;

namespace LiteHtmlSharp
{
   public static class PInvokes
   {
      
      #if __MonoCS__
      const string LiteHtmlLibFile = "litehtml";
      #else
      const string LiteHtmlLibFile = "LiteHtmlLib.dll";
      #endif

      public const CallingConvention cc = CallingConvention.Cdecl;



      #region Tests

      [DllImport(LiteHtmlLibFile, CallingConvention = cc)]
      public static extern void SetTestFunction(CallbackFunc func);

      [DllImport(LiteHtmlLibFile, CallingConvention = cc)]
      public static extern void SetTestCallback(IntPtr container, CallbackFunc func);

      [DllImport(LiteHtmlLibFile, CallingConvention = cc)]
      public static extern void TriggerTestCallback(IntPtr container);

      #endregion



      #region Callback Injection

      [DllImport(LiteHtmlLibFile, CallingConvention = cc)]
      public static extern void SetDrawBorders(IntPtr container, DrawBordersFunc func);

      [DllImport(LiteHtmlLibFile, CallingConvention = cc)]
      public static extern void SetDrawBackground(IntPtr container, DrawBackgroundFunc func);

      [DllImport(LiteHtmlLibFile, CallingConvention = cc)]
      public static extern void SetGetImageSize(IntPtr container, GetImageSizeFunc func);

      #endregion



      #region Instance Methods

      [DllImport(LiteHtmlLibFile, CallingConvention = cc, CharSet = CharSet.Unicode, SetLastError = true)]
      public static extern void RenderHTML(IntPtr container, string html);

      [DllImport(LiteHtmlLibFile, CallingConvention = cc, CharSet = CharSet.Unicode, SetLastError = true)]
      public static extern void SetMasterCSS(IntPtr container, string css);

      [DllImport(LiteHtmlLibFile, CallingConvention = cc, SetLastError = true)]
      public static extern bool OnMouseMove(IntPtr container, int x, int y);

      [DllImport(LiteHtmlLibFile, CallingConvention = cc, SetLastError = true)]
      public static extern void Draw(IntPtr container);

      #endregion



      [DllImport(LiteHtmlLibFile, CallingConvention = cc, SetLastError = true)]
      public static extern IntPtr Init();
   }
}

