﻿using System;

namespace FamilyTreeCodecGedcom
{
  class GedcomParserProgress
  {
    public Byte[] data;

    public long size;
    public long position;

    public GedcomParserProgress(Byte[] dataPointer, long inDataSize)
    {
      data = dataPointer;
      size = inDataSize;
      position = 0;
    }
    public bool IsEndOfFile()
    {
      return position >= size;
    }
  }

}
