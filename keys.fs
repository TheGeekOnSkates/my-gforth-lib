\ These move the cursor based on what key we're checking.
\ Note that some keys actually produce 3 characters; i.e.
\ The arrows are things like "\x1b[A", so that translates
\ like this: 0x1B = 27, [ = 91, A = ...66?  lol I forget
\ which numbers correspond to which keys.  But the bottom
\ line here is that to use this you may have to do stuff
\ like "key key key isUp isDown isLeft isRight".  Or for
\ a kinda crazy real-world example, try this:
\ : test   0 100 DO key key key isUp isDown isLeft isRight LOOP ;
\
\ TO-DO'S:
\       1. Finish getKey so it puts one of the following constants on the stack
\       2. Finish adding constants :)
\

1   constant key-ctrl-A
2   constant key-ctrl-B
3   constant key-ctrl-C
4   constant key-ctrl-D
\ ...
\ A few notes on these...
\     1. CTRL-C causes a "user interrupt"; don't go there
\     2. If CTRL is pressed, it doesn't matter if Shift is pressed or not.
\     3. And of course, a lot of these statements probably vary by terminal

27  constant key-escape
\ ...

32  constant key-space
\ ...

65  constant key-shift-A
66  constant key-shift-B
67  constant key-shift-C
68  constant key-shift-D
69  constant key-shift-E
70  constant key-shift-F
71  constant key-shift-G
72  constant key-shift-H
73  constant key-shift-I
74  constant key-shift-J
75  constant key-shift-K
76  constant key-shift-L
77  constant key-shift-M
78  constant key-shift-N
79  constant key-shift-O
80  constant key-shift-P
81  constant key-shift-Q
82  constant key-shift-R
83  constant key-shift-S
84  constant key-shift-T
85  constant key-shift-U
86  constant key-shift-V
87  constant key-shift-W
88  constant key-shift-X
89  constant key-shift-Y
90  constant key-shift-Z
\ ...

97  constant key-A
98  constant key-B
99  constant key-C
100 constant key-D
101 constant key-E
102 constant key-F
103 constant key-G
104 constant key-H
105 constant key-I
106 constant key-J
107 constant key-K
108 constant key-L
109 constant key-M
110 constant key-N
111 constant key-O
112 constant key-P
113 constant key-Q
114 constant key-R
115 constant key-S
116 constant key-T
117 constant key-U
118 constant key-V
119 constant key-W
120 constant key-X
121 constant key-Y
122 constant key-Z
\ ...  


\ Clears standard input (stdin)
: DROP-KEYS ( -- )
	BEGIN
		KEY?
		TRUE = IF
			KEY DROP
		THEN
	KEY? FALSE = UNTIL
;

: getChar ( -- key ) begin key? until key ;
: getKey
	getChar
	key? -1 = if key then
	key? -1 = if key then
;
: escaped?
	depth 3 < if 0			\ If depth < 3 then no
	else 2 pick 27 = 		\ Return whether the 3rd number on the stack == 27
	then
;

\ TO-DO: Rework these to use escaped?
: isLeft ( n -- n )    dup 68 = IF left THEN ;
: isRight ( n -- n )   dup 67 = IF right THEN ;
: isUp ( n -- n )      dup 65 = IF up THEN ;
: isDown ( n -- n )    dup 66 = IF down THEN ;
