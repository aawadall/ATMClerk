# High Level Architecture
## Immutable Transactions List
Allows writes and reads, but no updates or delete. Each transaction entry has a common header format, and a class specific body.

### Transaction Header
Transaction headers are made of the following common fields:
- **Transaction ID**: A unique GUID identifying a transaction entry  
- **Entry Timestamp**: Time when this entry was stored in the immutable transactions store 
- **Transaction Class**: a string defining direction of a transaction, see [Proposed Transaction classes](#proposed-transaction-classes) section 
- **Transaction Type**: a string defining purpose of this transaction

#### Proposed Transaction Classes
1. Projected Transaction
1. Actual Transaction
1. Transaction Confirmation 
1. Correction Transaction

#### Proposed Transaction Types
TBD

### Transaction Body 
## Derived Stories
## Workers
## Reporting Service
## Presentation Service
## API
