# ATMClerk
event driven ATM reconciliation system
## About ATMClerk
This repo is an attempt to scratch my own itch. 
I am trying to build a new ATM Cash Management system based on problems I am currently facing with an inhouse system.
_Why not fix your own system you ask?_ well, I'm glad you asked.
This in-house system was built using the wrong design, changing it to solve the problems I am facing would mean a complete re-write. hence this project.

So, back to the original question; _what this project does?_
Let us first define how an ATM works.
_Automatic Teller Machine_ **(ATM)** is a blend of a safe, lending agent, and a robot. 

ATM owner would feed the safe inside the machine with some cash. This safe is made of some compartments called _cassettes_, each cassette is filled with one type of _denomination_; think USD $20s or CAD $50s, etc. 

when you insert your card, key in your PIN, and ask for some cash, this machine will have a brief chat with its driver (_called ATM Switch_), and that driver will advise the machine to dispense certain number of notes from each cassettes.

when you walk away from that ATM with cash, your bank account was debited with that amount, while the ATM account (yes ATMs has bank accounts) it gets credited with the same amount. in some cases ATM owner would charge you surcharge amount, in some other cases, your bank gets charged what is called _interchange amount_.

_so what's the big deal you ask?_

at the end of the day, we need to solve the following problems:
- How much should we load into each cassette?
- when will this ATM run out of cash?
- when should we re-fill this ATM?
- did the ATM dispense all the amount it was credited?
- are there any mistakes counting notes while filling the machine?
- did the machine miscount notes while dispensing?
- did any human in the _replineshment loop_ make a mistake? maybe a not so honest mistake?

you see how things are getting complicated?

And that's not all, there are some subtle exceptions to handle. For example, when we decide to refill the machine, we don't just decide to fill it. we need to get cash from some cash provider, sort notes, fill cassettes, and send some technician to service this machine. 
this needs some lead time. 

## TODO
- [ ] Bundle business entities in a single namespace
- [ ] Separate data persistance from entity objects
- [ ] Create Worker module to handle unprocessed jobs 

## Items to include
ensure the following sections are defined
- [ ] What the project does
- [ ] The features and benefits of the project
- [ ] How users can get started with the project
- [ ] Where users can get help with your project
- [ ] Who maintains and contributes to the project
