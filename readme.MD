# Syncfusion Date Filter Bug

## Setup License Key

Add a syncfusion license key (version 27.1.52) to the program.cs file

## Problem

When filtering on date, choosing any date closes the dialog pop up and the date doesn't apply

## Reproduction

Go to the `/weather` page and attempt to apply a date filter


## Extra info

There is also a bug here with filtering on string values (ShipName or CustomerName).
I've specified in the `GridFilterSettings` that filtering should only happen on enter on on button click
and yet it still searches automatically on typing