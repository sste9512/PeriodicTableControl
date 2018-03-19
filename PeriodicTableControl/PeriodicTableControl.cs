using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PT_ContextMenu;

namespace PeriodicTableControl
{
   


    public class PeriodicTableControl : WrapPanel
    {

        public static String[] elementSymbol = {
           "H",
"He",
"Li",
"Be",
"B",
"C",
"N",
"O",
"F",
"Ne",
"Na",
"Mg",
"Al",
"Si",
"P",
"S",
"Cl",
"Ar",
"K",
"Ca",
"Sc",
"Ti",
"V",
"Cr",
"Mn",
"Fe",
"Co",
"Ni",
"Cu",
"Zn",
"Ga",
"Ge",
"As",
"Se",
"Br",
"Kr",
"Rb",
"Sr",
"Y",
"Zr",
"Nb",
"Mo",
"Tc",
"Ru",
"Rh",
"Pd",
"Ag",
"Cd",
"In",
"Sn",
"Sb",
"Te",
"I",
"Xe",
"Cs",
"Ba",
"La",
"Ce",
"Pr",
"Nd",
"Pm",
"Sm",
"Eu",
"Gd",
"Tb",
"Dy",
"Ho",
"Er",
"Tm",
"Yb",
"Lu",
"Hf",
"Ta",
"W",
"Re",
"Os",
"Ir",
"Pt",
"Au",
"Hg",
"Tl",
"Pb",
"Bi",
"Po",
"At",
"Rn",
"Fr",
"Ra",
"Ac",
"Th",
"Pa",
"U",
"Np",
"Pu",
"Am",
"Cm",
"Bk",
"Cf",
"Es",
"Fm",
"Md",
"No",
"Lr",
"Rf",
"Db",
"Sg",
"Bh",
"Hs",
"Mt",
"Ds",
"Rg",
"Cn",
"Nh",
"Fl",
"Mc",
"Lv",
"Ts",
"Og"  };

        /// <summary>
        /// Defines the molWeights
        /// </summary>
        public static double[] molWeights = {
            1.0079,
            4.0026,
            6.941,
            9.0122,
            10.811,
            12.0107,
            14.0067,
            15.9994,
            18.9984,
            20.1797,
            22.9897,
            24.305,
            26.9815,
            28.0855,
            30.9738,
            32.065,
            35.453,
            39.0983,
            39.948,
            40.078,
            44.9559,
            47.867,
            50.9415,
            54.938,
            55.845,
            58.6934,
            58.9332,
            63.546,
            65.39,
            69.723,
            72.64,
            74.9216,
            78.96,
            79.904,
            83.8,
            85.4678,
            87.62,
            88.9059,
            91.224,
            92.9064,
            95.94,
            98,
            101.07,
            102.9055,
            106.42,
            107.8682,
            112.411,
            114.818,
            118.71,
            121.76,
            126.9045,
            127.6,
            131.293,
            132.9055,
            137.327,
            138.9055,
            140.116,
            140.9077,
            144.24,
            145,
            150.36,
            151.964,
            157.25,
            158.925,
            162.5,
            164.9303,
            167.259,
            168.9342,
            173.04,
            174.967,
            178.49,
            180.9479,
            183.84,
            186.207,
            190.23,
            192.217,
            195.078,
            196.9665,
            200.59,
            204.3833,
            207.2,
            208.9804,
            209,
            210,
            222,
            223,
            226,
            227,
            231.0359,
            232.0381,
            237,
            238.0289,
            243,
            244,
            247,
            247,
            251,
            252,
            257,
            258,
            259,
            261,
            262,
            262,
            264,
            266,
            268,
            272,
            277};

        /// <summary>
        /// Defines the fullChemNames
        /// </summary>
        public static String[] fullChemNames = {
           "Hydrogen",
"Helium",
"Lithium",
"Beryllium",
"Boron",
"Carbon",
"Nitrogen",
"Oxygen",
"Fluorine",
"Neon",
"Sodium",
"Magnesium",
"Aluminum",
"Silicon",
"Phosphorus",
"Sulfur",
"Chlorine",
"Argon",
"Potassium",
"Calcium",
"Scandium",
"Titanium",
"Vanadium",
"Chromium",
"Manganese",
"Iron",
"Cobalt",
"Nickel",
"Copper",
"Zinc",
"Gallium",
"Germanium",
"Arsenic",
"Selenium",
"Bromine",
"Krypton",
"Rubidium",
"Strontium",
"Yttrium",
"Zirconium",
"Niobium",
"Molybdenum",
"Technetium",
"Ruthenium",
"Rhodium",
"Palladium",
"Silver",
"Cadmium",
"Indium",
"Tin",
"Antimony",
"Tellurium",
"Iodine",
"Xenon",
"Cesium",
"Barium",
"Lanthanum",
"Cerium",
"Praseodymium",
"Neodymium",
"Promethium",
"Samarium",
"Europium",
"Gadolinium",
"Terbium",
"Dysprosium",
"Holmium",
"Erbium",
"Thulium",
"Ytterbium",
"Lutetium",
"Hafnium",
"Tantalum",
"Tungsten",
"Rhenium",
"Osmium",
"Iridium",
"Platinum",
"Gold",
"Mercury",
"Thallium",
"Lead",
"Bismuth",
"Polonium",
"Astatine",
"Radon",
"Francium",
"Radium",
"Actinium",
"Thorium",
"Protactinium",
"Uranium",
"Neptunium",
"Plutonium",
"Americium",
"Curium",
"Berkelium",
"Californium",
"Einsteinium",
"Fermium",
"Mendelevium",
"Nobelium",
"Lawrencium",
"Rutherfordium",
"Dubnium",
"Seaborgium",
"Bohrium",
"Hassium",
"Meitnerium",
"Darmstadtium",
"Roentgenium",
"Copernicium",
"Nihonium",
"Flerovium",
"Moscovium",
"Livermorium",
"Tennessine",
"Oganesson"};












        bool firstRowIsFinished = false;
        bool secondRowIsFinished = false;
        bool thirdRowIsFinished = false;





        static PeriodicTableControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PeriodicTableControl), new FrameworkPropertyMetadata(typeof(PeriodicTableControl)));
        }

        public PeriodicTableControl()
        {
            for (int i = 0; i < 108; i++)
            {

                if (i == 1 && !firstRowIsFinished)
                {

                    for (int c = 0; c < 16; c++)
                    {
                        Border border1 = new Border();
                        border1.BorderBrush = Brushes.White;
                        border1.BorderThickness = new Thickness(1, 1, 1, 1);
                        border1.Margin = new Thickness(3, 3, 3, 3);
                        border1.Height = 120;
                        border1.Width = 90;
                        border1.Opacity = 0;
                        this.Children.Add(border1);
                    }
                    firstRowIsFinished = true;

                }

                if (i == 4 && firstRowIsFinished)
                {

                    for (int c = 0; c < 10; c++)
                    {
                        Border border1 = new Border();
                        border1.BorderBrush = Brushes.White;
                        border1.BorderThickness = new Thickness(1, 1, 1, 1);
                        border1.Margin = new Thickness(3, 3, 3, 3);
                        border1.Height = 120;
                        border1.Width = 90;
                        border1.Opacity = 0;
                        this.Children.Add(border1);
                    }
                    secondRowIsFinished = true;

                }

                if (i == 12 && secondRowIsFinished)
                {

                    for (int c = 0; c < 10; c++)
                    {
                        Border border1 = new Border();
                        border1.BorderBrush = Brushes.White;
                        border1.BorderThickness = new Thickness(1, 1, 1, 1);
                        border1.Margin = new Thickness(3, 3, 3, 3);
                        border1.Height = 120;
                        border1.Width = 90;
                        border1.Opacity = 0;
                        this.Children.Add(border1);
                    }
                    thirdRowIsFinished = true;

                }


               if(i == 57 && thirdRowIsFinished)
                {
                    StackPanel stack = new StackPanel();
                    stack.Orientation = Orientation.Horizontal;
                    stack.VerticalAlignment = VerticalAlignment.Bottom;
                    this.Children.Add(stack);
                    for (i = 57; i < 71; i++)
                    {
                        stack.Children.Add(generateStack(i));
                       
                    }



                }
                if (i == 89 && thirdRowIsFinished)
                {
                    DockPanel dock = new DockPanel();
                    dock.VerticalAlignment = VerticalAlignment.Bottom;
                    DockPanel.SetDock(this, Dock.Bottom);
                    
                    StackPanel stack = new StackPanel();
                    dock.Children.Add(stack);
                    stack.Orientation = Orientation.Horizontal;
                    stack.VerticalAlignment = VerticalAlignment.Bottom;
                    //this.Children.Add(stack);
                    for (i = 89; i < 103; i++)
                    {
                        stack.Children.Add(generateStack(i));

                    }



                }
               this.Children.Add(generateStack(i));
                this.Margin = new Thickness(6, 6, 6, 6);

              



            }


            






        }


        public Border generateStack(int i)
        {
            Border border = new Border();
            border.BorderBrush = Brushes.White;
            border.BorderThickness = new Thickness(1, 1, 1, 1);
            border.Margin = new Thickness(3, 3, 3, 3);

            StackPanel stack1 = new StackPanel();
            stack1.Orientation = Orientation.Vertical;
            stack1.Margin = new Thickness(4, 4, 4, 4);
            stack1.Width = 80;
            stack1.Height = 110;

            StackPanel numberStack = new StackPanel();
            numberStack.Orientation = Orientation.Horizontal;


            Label label = new Label();
            label.Content = i + 1;
            label.Foreground = Brushes.White;
            label.HorizontalAlignment = HorizontalAlignment.Left;


            numberStack.Children.Add(label);
            stack1.Children.Add(numberStack);

            StackPanel symbolPanel = new StackPanel();
            symbolPanel.Orientation = Orientation.Vertical;

            Label symbol = new Label();
            symbol.Content = elementSymbol[i];
            symbol.FontSize = 30;


            symbol.Foreground = Brushes.White;
            symbol.HorizontalAlignment = HorizontalAlignment.Center;
            symbolPanel.Children.Add(symbol);

            Label fullName = new Label();
            fullName.Content = fullChemNames[i];
            fullName.FontSize = 12;
            fullName.Foreground = Brushes.White;
            fullName.HorizontalAlignment = HorizontalAlignment.Center;
            symbolPanel.Children.Add(fullName);

            Label atomicWeight = new Label();
            atomicWeight.Content = molWeights[i];
            atomicWeight.FontSize = 12;
            atomicWeight.Foreground = Brushes.White;
            atomicWeight.HorizontalAlignment = HorizontalAlignment.Center;
            symbolPanel.Children.Add(atomicWeight);
            border.Child = stack1;
            stack1.Children.Add(symbolPanel);
          

            stack1.MouseEnter += (s, o) =>
            {

                border.BorderBrush = Brushes.CadetBlue;
                border.Background = Brushes.DarkSlateGray;

            };
            stack1.MouseLeave += (s, o) =>
            {

                border.BorderBrush = Brushes.White;
                border.Background = Brushes.Transparent;

            };
            stack1.MouseDown += (s, o) =>
            {
                ContextMenu menu = new ContextMenu();
                for(int d = 0; d < 10; d++)
                {
                    MenuItem item = new MenuItem();
                    item.Header = "This worked";
                    menu.Items.Add(item);
                }
                menu.IsOpen = true;

            };
          
            return border;
        }
    }
}
