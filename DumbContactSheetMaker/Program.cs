using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DumbContactSheetMaker
{
    static class Program
    {
        #region console stuff

        [DllImport("kernel32.dll")]
        static extern bool FreeConsole();

        #endregion





        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                switch (args[0])
                {
                    case "--fonts":
                        Console.WriteLine("available fonts:\n" + string.Join("\n    ", FontFamily.Families.Select(it => it.Name)));
                        return;
                    case "--help":
                    case "-h":
                        Console.WriteLine(Regex.Replace(@"
                            usage: DumbContactSheetMaker --help       to show this help
                                   DumbContactSheetMaker --fonts      to list available fonts

                                   DumbContactSheetMaker [<options>] <path> [<options>]
                            
                            options:
                                --output [i|r|<path>]               where to save the cover sheet
                                -o [i|r|<path>]                     defaults to root folder
                                                                     i: with the images
                                                                     r: in the root folder 
                                                                        (if recursive)
                                                                     <path>: specify your own dir

                                --recursive                         recursively search through
                                -r                                  sub directories and create
                                                                    contact sheet for all leaves
                                                                    of the directory tree
                                                                    
                                --width ###                         width of the contact sheet in
                                -w ###                              px
                                                                    
                                --height ###                        maximum thumbnail height in px
                                -h ###                              
                                                                    
                                --max-num ###                       maximum number of images to use
                                -mn ###                             in the contact sheet
                                                                    
                                --large-first                       make the first image fill the 
                                -lf                                 whole width of the contact 
                                                                    sheet
                                                                    
                                --cover <path>                      use a custom cover image that
                                -c <path>                           will fill the whole width of 
                                                                    the contact sheet
                                                                    
                                --cover-first                       use the cover image as the 
                                -cf                                 first image of the contact
                                                                    sheet (by default the cover
                                                                    will be put last)
                                                                    
                                --title                             show a title above the contact
                                -t                                  sheet
                                                                    
                                --title-text <custom title text>    provide a custom text to be used
                                -tt <custom title text>             as the title (by default the 
                                                                    directory name will be used)
                                                                    
                                --background <rgba hex>             background color for the title
                                -bg <rgba hex>                      default is black: 000000FF
                                                                    
                                --font <font name>                  font for the title, use --fonts
                                -f <font name>                      to list available fonts
                                                                    
                                --font-color <rgba hex>             text color for the title
                                -fc <rgba hex>                      default is white: FFFFFFFF
                                                                    
                                --font-size ###                     title's font size in pt
                                -fs ###                             
                                                                    
                                --font-style [b|i|bi]               title's font style, combination
                                -fst [b|i|bi]                        of (b)old and (i)talic
                        ", "^                            ", "", RegexOptions.Multiline));
                        return;
                    default:
                        DCSM.RunFromCommandLine(args);
                        return;
                }
            }
            FreeConsole();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
