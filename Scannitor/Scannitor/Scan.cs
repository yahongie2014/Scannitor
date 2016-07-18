﻿using System;
using com.google.zxing;

namespace scan
{
    public class scan : LuminanceSource
    {
        public byte[] PreviewBufferY { get; private set; }

        public scan(int width, int height)
            : base(width, height)
        {
            PreviewBufferY = new byte[width * height];
        }

        public override sbyte[] Matrix
        {
            get { return (sbyte[])(Array)PreviewBufferY; }
        }

        public override sbyte[] getRow(int y, sbyte[] row)
        {
            if (row == null || row.Length < Width)
            {
                row = new sbyte[Width];
            }

            for (int i = 0; i < Height; i++)
                row[i] = (sbyte)PreviewBufferY[i * Width + y];

            return row;
        }
    }
}