\ --------------------------------------------------------------------------------------------------------------------------------------------
\ Some ANSI escape-code stuff
\ For even more: https://gist.github.com/fnky/458719343aabd01cfb17a3a4f7296797
\ --------------------------------------------------------------------------------------------------------------------------------------------

: black         0 ;
: red           1 ;
: green         2 ;
: yellow        3 ;
: blue          4 ;
: pink          5 ;
: cyan          6 ;
: white         7 ;
: default       9 ;
: bold          .\" \x1b[1m" ;
: dark          .\" \x1b[2m" ;
: text          .\" \x1b[3" 48 + emit ." m" ;
: background    .\" \x1b[4" 48 + emit ." m" ;
: clear         .\" \x1b[2J\x1b[H" ;
: reset         .\" \x1b[0m" ;
: italic-on     .\" \x1b[3m" ;
: italic-off    .\" \x1b[23m" ;
: underline-on  .\" \x1b[4m" ;
: underline-off .\" \x1b[24m" ;
: blink-on      .\" \x1b[5m" ;
: blink-off     .\" \x1b[25m" ;
: reverse-on    .\" \x1b[7m" ;
: reverse-off   .\" \x1b[27m" ;
: hidden-on     .\" \x1b[8m" ;
: hidden-off    .\" \x1b[28m" ;
: home          .\" \x1b[H" ;
: up            .\" \x1b[A" ;
: down          .\" \x1b[B" ;
: right         .\" \x1b[C" ;
: left          .\" \x1b[D" ;

\ Printing numbers is SURPRISINGLY complexificated... Processing . . . . . . . . xD
\ Still wrapping my tiny human brain around it... hold area?  Conversion?
\ Radix? Extraction? Karapintra va Salensa?
\ lol sorry, been playing with the Nicendian language, in the fictional world I'm building for my book :D
\ Essentially Romance-language-y sounding gibberish that makes about as much sense as what I'm reading in their docs.  Seriously, what the puck? :D
\ Obviously, the idea is maximum flexibility, meaning it takes a lifetime to become a mega-guru and only those who have done so can fully understand it.
\ So for now, here are the 
\ https://gforth.org/manual/Formatted-numeric-output.html
\ At any rate, the usage should be: x y cursor (where x and y are numbers on the stack)
\ I've also attempted to encrypt it into die-hard Forthian shorthand below.
: cursor ( x y -- )   .\" \x1b[" 0 <<# #s #> type #>> ." ;" 0 <<# #s #> type #>> ." H" ;


