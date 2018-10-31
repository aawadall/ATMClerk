# Transaction Classes


## Planned Transaction 
An entry to request or plan a transaction, typically in the future, but it might point to past in case of cash loads.
This would be the first entry of a two legged transaction.

## Actual Transaction 
An entry to describe a single legged transaction. 

## Transaction Confirmation 
Realization of a planned transaction. 
This is the second leg of a two legged transaction.

## Correction 
An entry intended to correct transactions recorded in our transactions list.
As the transactions list is intended to be immutable, only writes and reads are allowed, but no deletes or updates are allowed. 
