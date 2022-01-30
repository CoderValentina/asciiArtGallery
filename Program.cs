// Author:Megan Morales
// Date:January 4,2022
// Description: Megans ASCII Art Console App
Console.Title = "Things About Me Using ASCII Art";
Console.WriteLine("Megans ASCII Art Console App ");
Console.WriteLine("January 4, 2022");
Console.WriteLine("===============================================");

// Create Variables to store the ascii art
string firstArt = @"           _.---.(       ..--._) 
       (_.'       `''-.'`      `'.
        /            /            \_)
     (_|    _,.-'""'-,-'""'-.,_   |
        \  /.--'           '--.\  /_)
      ,__\ ) (_(_(       )_)_) ) /__,
       \  (_, (  o)      (  o) /    /
       `--.-`  '-'   c    '-'  `-'-`
         (O\                   (O)
            '-.....__w__.....-'
";

string secondArt = @"
        _..._.-;-'
     .-'     `(
    /      ;   \
   ;.' ;`  ,;  ;
  .'' ``. (  \ ;
 / f_ _L \ ;  )\
 \/|` '|\/;; <;/
((; \_/  (()       
     """;

string thirdArt = @"
.      *    *           *.       *   .                      *     .
               .   .                   __   *    .     * .     *
    *       *         *   .     .    _|__|_        *    __   .       *
  .  *  /\       /\          *        ('')    *       _|__|_     .
       /  \   * /  \  *          .  <( . )> *  .       ('')   *   *
  *    /  \     /  \   .   *       _(__.__)_  _   ,--<(  . )>  .    .
      /    \   /    \          *   |       |  )),`   (   .  )     *
   *   `||` ..  `||`   . *.   ... ==========='`   ... '--`-` ... * 
";
string fourthArt = @"
 -------------------------------------------------------------------
XWXWXWXWXWXWXWXW                                   WXWXWXWXWXWXWXWX
WXWXWXWXWXWXWXWX                 A                 XWXWXWXWXWXWXWXW
XWXWXWXWXWXWXWXW                AWA                WXWXWXWXWXWXWXWX
WXWXWXWXWXWXWXWX           AA  AWXWA  AA           XWXWXWXWXWXWXWXW
XWXWXWXWXWXWXWXW            VWXWXWXWXWV            WXWXWXWXWXWXWXWX
WXWXWXWXWXWXWXWX        AA   VWXWXWXWV   AA        XWXWXWXWXWXWXWXW
XWXWXWXWXWXWXWXW    VWXWXWXA  VWXWXWV  AXWXWXWV    WXWXWXWXWXWXWXWX
WXWXWXWXWXWXWXWX     XWXWXWXWXWXWXWXWXWXWXWXWX     XWXWXWXWXWXWXWXW
XWXWXWXWXWXWXWXW   AXWXWXWXWXWXWXWXWXWXWXWXWXWXA   WXWXWXWXWXWXWXWX
WXWXWXWXWXWXWXWX      VXWXWXWXWXWXWXWXWXWXWXV      XWXWXWXWXWXWXWXW
XWXWXWXWXWXWXWXW         VXWXWXWXWXWXWXWXV         WXWXWXWXWXWXWXWX
WXWXWXWXWXWXWXWX           XWXWXWXWXWXWX           XWXWXWXWXWXWXWXW
XWXWXWXWXWXWXWXW         AXWXWXWXWXWXWXWXA         WXWXWXWXWXWXWXWX
WXWXWXWXWXWXWXWX                 I                 XWXWXWXWXWXWXWXW
XWXWXWXWXWXWXWXW                 I                 WXWXWXWXWXWXWXWX
WXWXWXWXWXWXWXWX                 I                 XWXWXWXWXWXWXWXW
XWXWXWXWXWXWXWXW                                   WXWXWXWXWXWXWXWX
-------------------------------------------------------------------
";

string fifthArt = @" 
        _____
    ,-:` \;',`'-, 
  .'-;_,;  ':-;_,'.
 /;   '/    ,  _`.-\
| '`. (`     /` ` \`|
|:.  `\`-.   \_   / |
|     (   `,  .`\ ;'|
 \     | .'     `-'/
  `.   ;/        .'
    `'-._____.
";
          
// Print the 1st favorite thing
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\n\n 1. My favorite cartoon character is Betty Boop.");
Console.WriteLine(firstArt);

// Now print the 2nd favorite thing
Console.ForegroundColor= ConsoleColor.Magenta;
Console.WriteLine("\n\n 2. My favorite dog is Lexi.");
Console.WriteLine(secondArt);

// Print the 3rd favorite thing
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n\n 3. My favorite holiday is Christmas.");
Console.WriteLine(thirdArt);

// Print the 4th favorite thing
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n\n 4. I want to travel to Canada.");
Console.WriteLine(fourthArt);

// Print the 5th favorite thing
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\n\n 5. I love Astronomy.");
Console.WriteLine(fifthArt);

Console.WriteLine("\n\n\nTHE END");