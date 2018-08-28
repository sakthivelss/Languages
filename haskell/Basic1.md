--http://learnyouahaskell.com/
variable name 
-------------
Following are valid variable names

test' = 10
test'' = 10  

``` 
strings are represented as array of char
Boolean values  -- True && False
negation -- not False
Equallity -- ==
````
some function
============
succ 9
min 9 8
max 0 7

List
=====
emplty list - []
list with element - [1,3,4]
lilst of list - [[2,23],[23,23,]]

comparing list 
[1,2,3] < [1,2,3]

function on list
================
head 
tail
last 
init
length
null - checks if the list is empty and returns true else false
reverse -
take n - extract n element from first element
drop n - subscrate the first element and takes the rest
maximum - returns largest element
minimum - returns smallest element
sum - sums the element in the list
product - multiplies the element in the list
elem 4 [3,3,5,4] - checks if the first arguments exists in the list
text range
[1..10] - creates the range of elements
 ['a'..'z'] -creates the range of small case letters
 [3,6..20]  - creates [3,6,7,..]
cycle [3,3,2] - takes the lists and cycles it into infinit list

list comprehension
==================
Example 1
=========
[x*2 | x <- [1,3,4], x <=10] > -- 

x*2 -- is called output function
x -- is the variable
x <- [1,2,4]  is the input set
x <=10 is the predicates. Addition predicate can be appendend by commas

example 2
length' ns = sum [1|_<-ns]


Tuple
=======
fst (9,23)
snd ('23','353')

zip ls1 ls2 - creates the list of pairs by combining ls1 and ls2
===========
zip [5,3,5] [0,3,6]


