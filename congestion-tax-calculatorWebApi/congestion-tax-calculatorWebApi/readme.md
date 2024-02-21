# instruction:

1. run congestion-tax-calculatorWebApi
2. once application is upp and running you should see swaggerui in front click on /CongestionTax and then "try it out"
3. enter your value in the body request i have included some example i used in the file ExampleValue.txt

## json example

{
"vehicle": "car",
"dates": [
"2013-01-14 21:00:00",
"2013-01-15 21:00:00",
"2013-02-07 06:23:27",
"2013-02-07 15:27:00",
"2013-02-08 06:27:00",
"2013-02-08 06:20:27",
"2013-02-08 14:35:00",
"2013-02-08 15:29:00",
"2013-02-08 15:47:00",
"2013-02-08 16:01:00",
"2013-02-08 16:48:00",
"2013-02-08 17:49:00",
"2013-02-08 18:29:00",
"2013-02-08 18:35:00",
"2013-03-26 14:25:00",
"2013-03-28 14:07:27"
]
}

# my focus:

My priority for this assignment was mainly to have a working happy case for calculating congestion tax. I did not do an active bug hunting, but any bug i stumbled upon while testing the happy cases i would fix. My priority looked something like this:
Implement happy case > fixing bugs > Refactor > bonus scenario

Besides the bonus scenario there were a lot more things i wanted to do but did not have time for. i though readability on some of the "if" cases was pretty bad on CongestionTaxCalculator i would have wrapped them in a function. i had a hard time understanding GetTollFee and GetTax at first if i had time i would have looked into those.
and also theres features such as error handling that i didnt have time to work on. Folder hierchy within the project was also something i could have worked more on.
