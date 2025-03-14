using RollingSun.Interfaces;
using System.Runtime.CompilerServices;

namespace RollingSun.Models.Telas {
    public class Blackout : ITela {
        public float Gramaje { get; }
        public bool IsSemitransparent { get; }
        public Color Tinte { get; set; }
        public Blackout(Color color) {
            Gramaje = 300f;
            IsSemitransparent = false;
            Tinte = color;
            }
        }

    public class Screen : ITela {
        public float Gramaje { get; }
        public bool IsSemitransparent { get; }
        public Color Tinte { get; set; }
        public Screen(Color color) {
            Gramaje = 120f;
            IsSemitransparent = true;
            Tinte = color;
            }
        }

    public class Algodon : ITela {
        public float Gramaje { get; }
        public bool IsSemitransparent { get; }
        public Color Tinte { get; set; }
        public Algodon(Color color,bool transparencia) {
            Gramaje = 120f;
            IsSemitransparent = transparencia;
            Tinte = color;
            }
        }

    public struct Color {
        public string Nombre;
        public int R;
        public int G;
        public int B;
        public string hex;

        public Color(string nombre, int red, int green, int blue) {
            Nombre = nombre;
            R = red;
            G = green;
            B = blue;
            hex = String.Concat(red.ToString("X"),green.ToString("X"),blue.ToString("X"));
            }

        public readonly Color Blanco { get => new Color("Blanco",235,235,237); }
        public readonly Color Negro { get => new Color("Negro",12,15,12); }
        public readonly Color Gris { get => new Color("Gris",110,116,122); }
        public readonly Color Beige { get => new Color("Beige",245,245,220); }
        public readonly Color Rojo { get => new Color("Rojo",224,60,49); }
        public readonly Color Verde { get => new Color("Verde",164,198,57); }
        public readonly Color Azul { get => new Color("Azul",64,128,191); }
        public readonly Color Anaranjado { get => new Color("Anaranjado",255,153,102); }
        public readonly Color Aguamarina { get => new Color("Aguamarina",180,255,230); }
        }
    }
