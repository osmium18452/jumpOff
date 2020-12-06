using System;
using System.ComponentModel;

namespace ConsoleApp1 {
    class Draw {
        public static void DrawAFloor(int width) {
            Console.Write("│ ");
            for (int i = 0; i < width; i++) {
                Console.Write("┌─┐ ");
            }
            Console.WriteLine("│ ");
            Console.Write("│ ");
            for (int i = 0; i < width; i++) {
                Console.Write("└─┘ ");
            }
            Console.WriteLine("│ ");
        }
        public static void DrawTop(int width) {
            Console.Write("┌");
            for (var i = 0; i < width; i++) {
                Console.Write("────");
            }
            Console.Write("─┐ \n");
        }

        public static void DrawGround(int width) {
            Console.Write("└");
            for (var i = 0; i < width; i++) {
                Console.Write("────");
            }
            Console.Write("─┴──────────── \n");
        }

        public static void DrawYourself(int width) {
            Console.Write("│ ");
            for (int i = 0; i < width; i++) {
                Console.Write("┌─┐ ");
            }
            Console.WriteLine("│ ");
            Console.Write("│ ");
            for (int i = 0; i < width; i++) {
                Console.Write("└─┘ ");
            }
            Console.WriteLine("│   ╰?╯");
            
            Console.Write("│ ");
            for (int i = 0; i < width; i++) {
                Console.Write("┌─┐ ");
            }
            Console.WriteLine("│    /  ");
            Console.Write("│ ");
            for (int i = 0; i < width; i++) {
                Console.Write("└─┘ ");
            }
            Console.WriteLine("│   />  ");
        }

        public static void DrawTitle(string title) {
            Console.Write("│     ");
            Console.Write(title);
            var length = Count.GetLen(title);
            for (var i=0;i< ((4 - length % 4) == 4 ? 0 : (4 - length % 4));i++) Console.Write(" ");
            Console.WriteLine("    │");
        }
    }

    class Count {
        public static int GetLen(string s) {
            var length = 0;
            foreach (var VARIABLE in s) {
                length+=System.Text.Encoding.GetEncoding("utf-8").GetByteCount(Convert.ToString(VARIABLE))>1?2:1;
            }

            return length;
        }
    }
    
    class Program {
        static void Main(string[] args) {
            int floor, height;
            Console.WriteLine("请输入你所在的建筑");
            var buildingTitle = Console.ReadLine();
            Console.WriteLine("请输入建筑的高度和你所在的层数");
            var buffer = Console.ReadLine().Split(" ");
            height = Convert.ToInt32(buffer[0]);
            floor = Convert.ToInt32(buffer[1]);
            var length = buildingTitle.Length;
            var buildingWidth = Count.GetLen(buildingTitle);
            var windows = 2 + (3 + buildingWidth) / 4;
            
            Draw.DrawTop(windows);
            Draw.DrawTitle(buildingTitle);
            for (var i=0;i<height-floor;i++) Draw.DrawAFloor(windows);
            Draw.DrawYourself(windows);
            for (var i=0;i<floor-2;i++) Draw.DrawAFloor(windows);
            Draw.DrawGround(windows);
            Console.ReadLine();
        }
    }
}