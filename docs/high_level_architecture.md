# High Level Architecture
## Immutable Transactions List
Allows writes and reads, but no updates or delete. Each transaction entry has a common _header_ format, and a class specific _body_.

### Transaction Header
Transaction headers are made of the following common fields:
- **Transaction ID**: A unique GUID identifying a transaction entry  
- **Entry Timestamp**: Time when this entry was stored in the immutable transactions store 
- **Transaction Class**: a string defining direction of a transaction, see [Proposed Transaction classes](#proposed-transaction-classes) section 
- **Transaction Type**: a string defining purpose of this transaction

#### Proposed Transaction Classes
1. **Projected Transaction**: A promise of a transaction. This is a two legged transaction, completed by a _Confirmation Transaction_.
1. **Actual Transaction**: Declaration of an actual transaction happening. This is a single legged transaction. 
1. **Confirmation Transaction**: Confirmation of the transaction promised in the _Projected Transaction_.
1. **Correction Transaction**: Correction of any of the transactions described above. This feature will make the list immutable; it will prevent deleting or modifying entries.

#### Proposed Transaction Types
1. Load Cash
1. Empty Cash 
1. Customer Transaction 
TBC

### Transaction Body 
Transaction body is class dependent, as below:

#### Projected Transaction Body 
In addition to common transaction (Event) header, it is required to have at least the following fields:

#### Actual Transaction Body 
#### Confirmation Transaction Body 
#### Correction Transaction Body 

## Derived Stories
## Workers
## Reporting Service
## Presentation Service
## API
