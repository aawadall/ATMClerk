# ATMClerk
event driven ATM reconciliation system

## TODO
- [ ] Bundle business entities in a single namespace
- [ ] Separate data persistance from entity objects
- [ ] Create Worker module to handle unprocessed jobs 

## High Level Architecture
### Immutable Transactions List
Allows writes and reads, but no updates or delete.

Proposed transaction classes are:
1. Projected Transaction
1. Actual Transaction
1. Transaction Confirmation 
1. Correction Transaction

### Derived Stories
### Workers
### Reporting Service
### Presentation Service
### API
