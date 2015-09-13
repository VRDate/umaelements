﻿using UnityEngine;
using System.Collections;

namespace UMAElements
{
	public class GamePalette
	{
		// this is your ingame color swatch. Change these to anything you want,
		// use more or fewer colors. It's up to you.
				
		public static XColor[] BodySwatch = new XColor[] {
	
			/*  0 - nothing				*/	new XColor(XColor.RGBA,   0,   0,   0,   0),
	
			/*  1 - human skin			*/	new XColor(XColor.RGBA, 255, 255, 255, 255),
			/*  2 - human skin			*/	new XColor(XColor.RGBA, 255, 128, 128, 255),
			/*  3 - human skin			*/	new XColor(XColor.RGBA, 255, 128, 128, 255),
			/*  4 - human skin			*/	new XColor(XColor.RGBA,   0, 255,   0, 255),
			/*  5 - human skin			*/	new XColor(XColor.RGBA, 255, 128, 128, 255),
			
			/*  6 - human skin			*/	new XColor(XColor.HSLA,   0, 153, 255, 255),
			/*  7 - human skin			*/	new XColor(XColor.HSLA, 121,  98, 255, 50),
			/*  8 - human skin			*/	new XColor(XColor.HSLA, 189, 153, 255, 255),
			
			/*  9 - human skin			*/	new XColor(XColor.RGBA, 255, 128, 128, 255),
			/* 10 - human skin			*/	new XColor(XColor.RGBA, 255, 128, 128, 255),
			/* 11 - human skin			*/	new XColor(XColor.RGBA, 255, 128, 128, 255),
			/* 12 - human skin			*/	new XColor(XColor.RGBA, 255, 128, 128, 255),
			/* 13 - human skin			*/	new XColor(XColor.RGBA, 255, 128, 128, 255),
			/* 14 - human skin			*/	new XColor(XColor.RGBA, 255, 128, 128, 255),
			/* 15 - human skin			*/	new XColor(XColor.RGBA, 255, 128, 128, 255),
			/* 16 - human skin			*/	new XColor(XColor.RGBA, 255, 128, 128, 255),
			/* 17 - human skin			*/	new XColor(XColor.RGBA, 255, 128, 128, 255),
			/* 18 - human skin			*/	new XColor(XColor.RGBA, 255, 128, 128, 255),
			/* 19 - human skin			*/	new XColor(XColor.RGBA, 255, 128, 128, 255),
			/* 20 - human skin			*/	new XColor(XColor.RGBA, 255, 128, 128, 255),

			/* 21 - orc skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 22 - orc skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 23 - orc skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 24 - orc skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 25 - orc skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 26 - orc skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 27 - orc skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 28 - orc skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 29 - orc skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 30 - orc skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 31 - orc skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 32 - orc skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 33 - orc skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 34 - orc skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 35 - orc skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 36 - orc skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 37 - orc skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 38 - orc skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 39 - orc skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 40 - orc skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),

			/* 41 - elf skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 42 - elf skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 43 - elf skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 44 - elf skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 45 - elf skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 46 - elf skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 47 - elf skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 48 - elf skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 49 - elf skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 50 - elf skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 51 - elf skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 52 - elf skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 53 - elf skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 54 - elf skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 55 - elf skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 56 - elf skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 57 - elf skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 58 - elf skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 59 - elf skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 60 - elf skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),

			/* 61 - troll skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 62 - troll skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 63 - troll skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 64 - troll skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 65 - troll skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 66 - troll skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 67 - troll skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 68 - troll skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 69 - troll skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 70 - troll skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 71 - troll skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 72 - troll skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 73 - troll skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 74 - troll skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 75 - troll skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 76 - troll skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 77 - troll skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 78 - troll skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 79 - troll skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 80 - troll skin			*/	new XColor(XColor.RGBA,255, 128, 128, 255),

			/* 81 - rare - greens		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 82 - rare - greens		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 83 - rare - mints		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 84 - rare - mints		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 85 - rare - cyans		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 86 - rare - cyans		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 87 - rare - azures		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 88 - rare - azures		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 89 - rare - blues		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 90 - rare - blues		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 91 - rare - violets		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 92 - rare - violets		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 93 - rare - magentas		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 94 - rare - magentas		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 95 - rare - roses		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 96 - rare - roses		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 81 - rare - greens		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 82 - rare - greens		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 83 - rare - mints		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 84 - rare - mints		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 85 - rare - cyans		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 86 - rare - cyans		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 87 - rare - azures		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 88 - rare - azures		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 89 - rare - blues		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 90 - rare - blues		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 91 - rare - violets		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 92 - rare - violets		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 93 - rare - magentas		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 94 - rare - magentas		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 95 - rare - roses		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 96 - rare - roses		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 81 - rare - greens		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 82 - rare - greens		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 83 - rare - mints		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 84 - rare - mints		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 85 - rare - cyans		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 86 - rare - cyans		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 87 - rare - azures		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 88 - rare - azures		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 89 - rare - blues		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 90 - rare - blues		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 91 - rare - violets		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 92 - rare - violets		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 93 - rare - magentas		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 94 - rare - magentas		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 95 - rare - roses		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
			/* 96 - rare - roses		*/	new XColor(XColor.RGBA,255, 128, 128, 255),
		};
		
		public static XColor[] DyeSwatch = new XColor[] {
	
			/*  0 - nothing				*/	new XColor(XColor.HSLA,   0,   0,   0,   0),
	
			/*  1 - basic dyes			*/	new XColor(XColor.HSLA,  34,  23, 181, 255),
			/*  2 - basic dyes			*/	new XColor(XColor.HSLA,  26,  81, 169, 255),
			/*  3 - basic dyes			*/	new XColor(XColor.HSLA, 148, 115, 162, 255),
			/*  4 - basic dyes			*/	new XColor(XColor.HSLA, 160,  75,  73, 255),
			/*  5 - basic dyes			*/	new XColor(XColor.HSLA, 141,  46, 148, 255),
			/*  6 - basic dyes			*/	new XColor(XColor.HSLA,  15, 191, 142, 255),
			/*  7 - basic dyes			*/	new XColor(XColor.HSLA,  28, 121, 111, 255),
			/*  8 - basic dyes			*/	new XColor(XColor.HSLA, 207, 105, 127, 255),
			/*  9 - basic dyes			*/	new XColor(XColor.HSLA,  19,  90, 115, 255),
			/* 10 - basic dyes			*/	new XColor(XColor.HSLA,  67, 229,  99, 255),
			/* 11 - basic dyes			*/	new XColor(XColor.HSLA,  26,  42, 111, 255),
			/* 12 - basic dyes			*/	new XColor(XColor.HSLA,   3, 172, 130, 255),
			/* 13 - basic dyes			*/	new XColor(XColor.HSLA, 135,  53, 101, 255),
			/* 14 - basic dyes			*/	new XColor(XColor.HSLA,  32,  36,  97, 255),
			/* 15 - basic dyes			*/	new XColor(XColor.HSLA,  18, 130,  97, 255),
			/* 16 - basic dyes			*/	new XColor(XColor.HSLA, 234, 207, 104, 255),
			/* 17 - basic dyes			*/	new XColor(XColor.HSLA,  69, 255,  79, 255),
			/* 18 - basic dyes			*/	new XColor(XColor.HSLA, 187, 126, 102, 255),
			/* 19 - basic dyes			*/	new XColor(XColor.HSLA,  19, 255,  83, 255),
			/* 20 - basic dyes			*/	new XColor(XColor.HSLA,   3, 255,  94, 255),
		};
	}
}