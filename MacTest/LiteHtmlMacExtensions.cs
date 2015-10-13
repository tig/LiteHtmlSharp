﻿using System;
using LiteHtmlSharp;
using CoreGraphics;
using AppKit;

namespace MacTest
{
   public static class LiteHtmlMacExtensions
   {
      public static CGRect ToRect(this position pos)
      {
         return new CGRect(pos.x, pos.y, pos.width, pos.height);
      }

      const float MaxByteAsFloat = (float)byte.MaxValue;

      public static CGColor ToCGColor(this web_color wc)
      {
         return new CGColor(wc.red / MaxByteAsFloat, wc.green / MaxByteAsFloat, wc.blue / MaxByteAsFloat, wc.alpha / MaxByteAsFloat);
      }

      public static NSColor ToNSColor(this web_color wc)
      {
         return NSColor.FromRgba(wc.red / MaxByteAsFloat, wc.green / MaxByteAsFloat, wc.blue / MaxByteAsFloat, wc.alpha / MaxByteAsFloat);
      }

   }
}

