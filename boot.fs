\ Custom boot message
\ --------------------------------------------------------------------------

: _boot_message
	clear-history		\ Clear the Forth history file
	sys-clear		\ Clear the terminal screen
	bold yellow text	\ Self-explanatory :)
	.\" Gforth 0.7.3\n"
	blue text
	." Go FORTH and have fun! " smile .\" \n"
	reset			\ Reset terminal to default colors
;

\ And this is the "hook" - tells Gforth that the word I just defined
\ IS their pre-defined word, "bootmessage" (3-4 lines by default)
' _boot_message is bootmessage
