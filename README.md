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




https://medium.com/swlh/simple-event-souring-with-c-ec1eff55ee9d
https://itnext.io/implementing-event-store-in-c-8a27138cc90
https://github.com/bolicd/eventstore
https://github.com/aneshas/tactical-ddd