using Satisfactory_calculator_C.Utilities;
using System.IO;
using System;

// Pathwork
var ResourceFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Resources");
var ItemListPath = Path.Combine(ResourceFolder,Constants.DATA_FILE);

// Requested items defined 
var RequestedItem = "Screw";
var RequestedItemType = "Original";
var RequestedQty = 120;
var RequestedItemOverclock = 100;

// Requested power generation defined 
var RequestedPower = "Coal";
var RequestedFuelType = "Coal";
var RequestedPowerOverclock = 100;


// Finding the line in the excel file
var CompSheet = new ReadExcel(ItemListPath,Constants.DS_COMP).WorkSheet;

// First read in the excel file

