# CheckOut

Just a kata picked to practice TDD in pai programming 9Worked with (Aleksey Groshev - https://github.com/alex-groshev)


We’re going to see how far we can get in implementing a supermarket checkout that calculates the total price of a number of items. In a normal supermarket, things are identified using Stock Keeping Units, or SKUs. In our store, we’ll use individual letters of the alphabet (A, B, C, and so on). Our goods are priced individually. In addition, some items are multipriced: buy n of them, and they’ll cost you y pounds. For example, item ‘A’ might cost 50 pounds individually, but this week we have a special offer: buy three ‘A’s and they’ll cost you 130. The price and offer table:

Item  Price   Offer
--------------------------
A     50       3 for 130
B     30       2 for 45
C     20
D     15

Our checkout accepts items in any order, so that if we scan a B, an A, and another B, we’ll recognize the two B’s and price them at 45 (for a total price so far of 95).

Getting Started

The interface to your checkout can be anything you like but we’d suggest passing in a string of SKUs to begin with. Here are the first few tests from a Ruby implementation, but feel free to use any language, and write the tests in any order you prefer:

[TestCase("", 0)]
[TestCase("A", 50)]
[TestCase("AB", 80)]
[TestCase("CDBA",115)]
[TestCase("AA", 100)]
[TestCase("AAA",130)]
[TestCase("AAAA", 180)]
[TestCase("AAABB", 175)]
[TestCase("AAAAAA", 260)]
