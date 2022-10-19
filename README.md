# event-source-example

This is going to be an API which manages a domain entity

- people GET, 
- life events:
  - born (req parents, date)
  - died (req date)
  - married
  - divorced
  - school grades
  - more...

api processes request (business logic) and appends events
consumer to listen for change feed and rebuilds read only view model

Future:
- snapshotting
- deployment
- terraform
- containerise
- AKS