\ --------------------------------------------------------------------------------------------------------------------------------------------
\ Misc. text-interface stuff
\ --------------------------------------------------------------------------------------------------------------------------------------------

: title ( n1 n2 n3 -- )    clear reverse-on spaces home type reverse-off 1 2 cursor ;
\ Where n1 is a string pointer and n2 is the length of that string (use s" for these numbers),
\ and n3 is the number of spaces to print (with reverse on) for the title - ideally the width of your terminal)
\ example: s" Title Here" 80 title

\ TO-DO: Add words for box-drawing characters, getting input from the user, etc.
