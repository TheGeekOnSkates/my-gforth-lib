\ --------------------------------------------------------------------------------------------------------------------------------------------
\ Misc. text-interface stuff
\ --------------------------------------------------------------------------------------------------------------------------------------------

: title ( n1 n2 n3 -- )    clear reverse-on spaces home type reverse-off 1 2 cursor ;
\ Where n1 is a string pointer and n2 is the length of that string (use s" for these numbers),
\ and n3 is the number of spaces to print (with reverse on) for the title - ideally the width of your terminal)
\ example: s" Title Here" 80 title

\ TO-DO: Add words for box-drawing characters, getting input from the user, etc.

: fill-low-1 ." ▁" ;
: fill-low-2 ." ▂" ;
: fill-low-3 ." ▃" ;
: fill-low-4 ." ▄" ;
: fill-low-5 ." ▅" ;
: fill-low-6 ." ▆" ;
: fill-low-7 ." ▇" ;
: fill-all ." █" ;
: fill-hi-1 ." ▔" ;
: fill-hi-4 ." ▀" ;
: fill-right-1 ." ▕" ;
: fill-left-7 ." ▉" ;
: fill-left-6 ." ▊" ;
: fill-left-5 ." ▋" ;
: fill-left-4 ." ▌" ;
: fill-left-3 ." ▍" ;
: fill-left-2 ." ▎" ;
: fill-left-1 ." ▏" ;
: fill-right-half ." ▐" ;
: shade-25 ." ░" ;
: shade-50 ." ▒" ;
: shade-75 ." ▓" ;
: pixel-bottom-left ." ▖" ;
: pixel-bottom-right ." ▗" ;
: pixel-top-left ." ▘" ;
: pixel-top-right ." ▝" ;
: pixel-all-but-top-left ." ▟" ;
: pixel-all-but-top-right ." ▙" ;
: pixel-all-but-bottom-left ." ▜" ;
: pixel-all-but-bottom-right ." ▛" ;
: pixel-diagonal-up ." ▞" ;
: pixel-diagonal-down ." ▚" ;

\ TO-DO: ═║╚╝╠╬╣╦╩╔╗╭╮╯╰╱╲╳
