using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Satisfactory_calculator_C.Utilities;

public class Constants {
    // Name of the excel file
    public static string DATA_FILE = "item_list.xlsx";

    // Data columns - Components
    public static string DC_ITEM = "Item";
    public static string DC_ITEM_TYPE = "item_type";
    public static string DC_DEFAULT_ITEM_TYPE = "Original";
    public static string DC_ITEM_QTY = "item_qty";
    public static string DC_ITEM_QTY_UNIT = "item_qty_unit";

    public static string DC_EXTRA_ITEM = "extra_item";
    public static string DC_EXTRA_ITEM_QTY = "extra_item_qty";
    public static string DC_EXTRA_ITEM_UNIT = "extra_item_qty_unit";

    public static string DC_CRAFT_TIME = "craft_time";
    public static string DC_CRAFT_TIME_UNIT = "craft_time_unit";

    public static string DC_INPUT_MAT = "DC_INPUT_MAT";
    public static string DC_INPUT_QTY = "DC_INPUT_QTY";
    public static string DC_INPUT_QTY_UNIT = "DC_INPUT_QTY_UNIT_";
    public static string DC_INPUT_MAT_1 = "input_mat_1";
    public static string DC_INPUT_QTY_1 = "input_qty_1";
    public static string DC_INPUT_QTY_UNIT_1 = "input_qty_unit_1";
    public static string DC_INPUT_MAT_2 = "input_mat_2";
    public static string DC_INPUT_QTY_2 = "input_qty_2";
    public static string DC_INPUT_QTY_UNIT_2 = "input_qty_unit_2";
    public static string DC_INPUT_MAT_3 = "input_mat_3";
    public static string DC_INPUT_QTY_3 = "input_qty_3";
    public static string DC_INPUT_QTY_UNIT_3 = "input_qty_unit_3";
    public static string DC_INPUT_MAT_4 = "input_mat_4";
    public static string DC_INPUT_QTY_4 = "input_qty_4";
    public static string DC_INPUT_QTY_UNIT_4 = "input_qty_unit_4";

    public static string DC_CRAFTED_IN = "crafted_in";
    public static string DC_ITEM_PER_MIN = "item_per_min";

    // Data columns - Logistics
    public static string DC_CAPACITY = "capacity";
    public static string DC_CAPACITY_UNIT = "capacity_unit";

    // Data columns - Power
    public static string DC_FUEL_TYPE = "fuel_type";
    public static string DC_POWER_GEN = "power_gen";
    public static string DC_POWER_GEN_UNIT = "power_gen_unit";
    public static string DC_POWER_INPUT_MAT = "DC_POWER_INPUT_MAT";
    public static string DC_POWER_INPUT_QTY = "DC_POWER_INPUT_QTY";
    public static string DC_POWER_INPUT_QTY_UNIT = "DC_POWER_INPUT_QTY_UNIT";
    public static string DC_POWER_INPUT_MAT_1 = "input_mat_1";
    public static string DC_POWER_INPUT_QTY_1 = "input_qty_1";
    public static string DC_POWER_INPUT_QTY_UNIT_1 = "input_qty_unit_1";
    public static string DC_POWER_INPUT_MAT_2 = "input_mat_2";
    public static string DC_POWER_INPUT_QTY_2 = "input_qty_2";
    public static string DC_POWER_INPUT_QTY_UNIT_2 = "input_qty_unit_2";

    // Data columns - Buildings
    public static string DC_POWER_USE = "power_consumption";
    public static string DC_POWER_UNIT = "power_unit";

    // Data columns - Raw Materials
    public static string DC_RAW_NODE = "node";

    // Naming of Data Sheets
    public static string DS_RAW = "raw_material";
    public static string DS_COMP = "components";
    public static string DS_POWER = "power";
    public static string DS_BUILD = "buildings";
    public static string DS_LOG = "logistics";

    // Array of Data Sheets 
    public static string[] DS_SHEETS = {DS_RAW, DS_COMP, DS_POWER, DS_BUILD, DS_LOG};

}