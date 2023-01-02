\ --------------------------------------------------------------------------------------------------------------------------------------------
\ Map these Forth words to system commands
\ --------------------------------------------------------------------------------------------------------------------------------------------

: pwd           s" pwd" system ;
: up1           s" ../" set-dir ;
: vim           s" vim" system ;
: telnet        s" telnet" system ;
: files         s" clear" system pwd 10 emit s" ls" system ;

\ These are prefixed with "sys-" because they don't do
\ the same as their ANSI escape code counterparts.  Like
\ "reset" doesn't just reset terminal attributes; it also
\ clears the screen.  Similarly, the ANSI "clear" doesn't
\ actually clear the screen - you can scroll up to see what was "cleared".
: sys-clear     s" clear" system ;
: sys-reset     s" reset" system ;
: clear-history s" rm ~/.gforth-history" system ; \ Clears the up-arrow history
: edit-my-stuff s" vim ~/my-stuff.fs" system ;

\ This uses Voxin, a really cool text-to-speech program providing the classic "Eloquence" voice on Linux.
\ I'm still learning the conventional way of documenting stack effects, so I hope str* and strlen make sense (think C).
\ Basically what you want to do is s" text to be spoken" say
: say  ( str* strlen -- )   s\" voxin-say \"" pad place pad +place s\" \" | aplay -q" pad +place pad count system ;



