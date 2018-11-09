# High Level Architecture
## Immutable Transactions List
Allows writes and reads, but no updates or delete. Each transaction entry has a common _header_ format, and a class specific _body_.

### Transaction Header
Transaction headers are made of the following common fields:
- **Transaction ID**: A unique GUID identifying a transaction entry  
- **Entry Timestamp**: Time when this entry was stored in the immutable transactions store 
- **Transaction Class**: a string defining direction of a transaction, see [Proposed Transaction classes](#proposed-transaction-classes) section 
- **Transaction Type**: a string defining purpose of this transaction
- **Entity Account Number**: an internal identifier to an entity handled by the system; Cassette, ATM, Cash Provider, Packing Depot, Delivery Depot, Carrier, etc. 

#### Proposed Transaction Classes
1. **Projected Transaction**: A promise of a transaction. This is a two legged transaction, completed by a _Confirmation Transaction_.
1. **Actual Transaction**: Declaration of an actual transaction happening. This is a single legged transaction. 
1. **Confirmation Transaction**: Confirmation of the transaction promised in the _Projected Transaction_.
1. **Correction Transaction**: Correction of any of the transactions described above. This feature will make the list immutable; it will prevent deleting or modifying entries.

#### Proposed Transaction Types
1. Load Cash
1. Empty Cash 
1. Customer Transaction 

### Transaction Body 
Transaction body is class dependent, as below:

#### Projected Transaction Body 
In addition to common transaction (Event) header, it is required to have at least the following fields:
1. Target Date
1. Target Machine ID
1. Target Target Amount; as list of amount objects
1. Executer; Carrier/Armored Truck

_**Note**: that this transaction class can be used only for the following transaction types:_
- Load Cash
- Empty Cash 

#### Actual Transaction Body 
#### Confirmation Transaction Body 
#### Correction Transaction Body 

### Common Objects
There are some objects embedded into events that are commonly shared among different event messages

- Amount
- Carrier 
- Currency 
- Denomination 
- ATM
## Derived Stories
Stories are relations between different events imported into the system. for example, we could define a story of an ATM cycle by the following events:

1. Order Cash Load
1. Confirm Cash Load
1. User Transactions
1. Order Empty Cash 
1. Confirm Empty Cash 

The story derived from the events above would describe starting balance of this cycle, when it started,how much was dispensed and deposited, when this cycle ended, and how much cash was returned.


## Workers
## Reporting Service
## Presentation Service
## API
