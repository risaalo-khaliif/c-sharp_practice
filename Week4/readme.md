# Chapter four Part 1 Loops

## Topics 
5.1 The while Loop
5.2 The ++ and -- Operators
5.3 The for Loop
5.4 The do-while Loop

### The While Loop
The `while loop` causes a statement or set of statements to
repeat as long as a Boolean expression is true.

A while loop has two parts:
1.A Boolean expression that is
tested for a true or false
value.
2.A statement or set of
statements that is repeated a
long as the Boolean
expression is true.

####  Structure of a while Loop

The general format of a while loop is:
while (BooleanExpression)
{
statements
}
`While Clause` : The first line of While Loop.
`Body` : Statements inside the curly braces.
`Iteration`: Each time the loop executes its statements.
`counter variables` : variables used to track how many times a loop runs.
#### Pretest Loop
The Loop  tests its condition before performing an iteration.
While Loop and For Loop are Pretest Loop.

#### An infinite loop 
Is a loop that will repeats until the program is interrupted.

### The increment and decrement Operators
To `increment` a variable means to increase its value and to `decrement` a
variable means to decrease its value.
C# provides the `++` and `--` operators to increment and decrement variables.

#### Postfix mode
Means to place the operators after their operands, it use old value, then change it.
Example : Count++
#### Prefix mode 
Means to place the operators before their operands ,change value first, then use it.
Example : --Count


### The for Loop
The `for loop` is specially designed for situations requiring a counter variable to control the number of times that a loop iterates.
#### The general format is:
for (InitializationExpression; TestExpression; UpdateExpression)
{
}

### The do-while Loop
The `do-while loop` is a `posttest` loop, which means it performs an
iteration before testing its Boolean expression.
The `do-while loop` execute the statements at least once even if the condition is false .