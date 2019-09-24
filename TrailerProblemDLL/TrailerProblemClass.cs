/* Title:           Trailer Problem Class
 * Date:            8-29-18
 * Author:          Terry Holmes
 * 
 * Description:     This class is for trailer problems */

using NewEventLogDLL;
using System;

namespace TrailerProblemDLL
{
    public class TrailerProblemClass
    {
        //setting up the classes
        EventLogClass TheEventLogClass = new EventLogClass();

        TrailerProblemDataSet aTrailerProbleDataSet;
        TrailerProblemDataSetTableAdapters.trailerproblemTableAdapter aTrailerProblemTableAdapter;

        InsertTrailerProblemEntryTableAdapters.QueriesTableAdapter aInsertTrailerProblemTableAdapter;

        UpdateTrailerProblemCostEntryTableAdapters.QueriesTableAdapter aUpdateTrailerProblemCostTableAdapter;

        UpdateTrailerProblemSolvedEntryTableAdapters.QueriesTableAdapter aUpdateTrailerProblemSolvedTableAdapter;

        UpdateTrailerProblemVendorEntryTableAdapters.QueriesTableAdapter aUpdateTrailerProblemVendorTableAdapter;

        FindOpenTrailerProblemsDataSet aFindOpenTrailerProblemsDataSet;
        FindOpenTrailerProblemsDataSetTableAdapters.FindOpenTrailerProblemsTableAdapter aFindOpenTrailerProblemsTableAdapter;

        FindTrailerProblemsByTrailerIDDataSet aFindTrailerProblemsByTrailerIDDataSet;
        FindTrailerProblemsByTrailerIDDataSetTableAdapters.FindTrailerProblemsByTrailerIDTableAdapter aFindTrailerProblemsByTrailerIDTableAdapter;

        FindTrailerProblemsByDateRangeDataSet aFindTrailerProblemsByDateRangeDataSet;
        FindTrailerProblemsByDateRangeDataSetTableAdapters.FindTrailerProblemsByDateRangeTableAdapter aFindTrailerProblemsByDateRangeTableAdapter;

        FindTrailerProblemByDateMatchDataSet aFindTrailerProblemByDateMatchDataSet;
        FindTrailerProblemByDateMatchDataSetTableAdapters.FindTrailerProblemByDateMatchTableAdapter aFindTrailerProblemByDateMatchTableAdapter;

        FindOpenTrailerProblemsByTrailerIDDataSet aFindOpenTrailerProblemsByTrailerIDDataSet;
        FindOpenTrailerProblemsByTrailerIDDataSetTableAdapters.FindOpenTrailerProblemByTrailerIDTableAdapter aFindOpenTrailerProblemsByTrailerIDTableAdapter;

        public FindOpenTrailerProblemsByTrailerIDDataSet FindOpenTrailerProblemsByTrailerID(int intTrailerID)
        {
            try
            {
                aFindOpenTrailerProblemsByTrailerIDDataSet = new FindOpenTrailerProblemsByTrailerIDDataSet();
                aFindOpenTrailerProblemsByTrailerIDTableAdapter = new FindOpenTrailerProblemsByTrailerIDDataSetTableAdapters.FindOpenTrailerProblemByTrailerIDTableAdapter();
                aFindOpenTrailerProblemsByTrailerIDTableAdapter.Fill(aFindOpenTrailerProblemsByTrailerIDDataSet.FindOpenTrailerProblemByTrailerID, intTrailerID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailer Problems Class // Find Open Trailer Problems By Trailer ID " + Ex.Message);
            }

            return aFindOpenTrailerProblemsByTrailerIDDataSet;
        }
        public FindTrailerProblemByDateMatchDataSet FindTrailerProblemByDateMatch(DateTime datTransactionDate)
        {
            try
            {
                aFindTrailerProblemByDateMatchDataSet = new FindTrailerProblemByDateMatchDataSet();
                aFindTrailerProblemByDateMatchTableAdapter = new FindTrailerProblemByDateMatchDataSetTableAdapters.FindTrailerProblemByDateMatchTableAdapter();
                aFindTrailerProblemByDateMatchTableAdapter.Fill(aFindTrailerProblemByDateMatchDataSet.FindTrailerProblemByDateMatch, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailer Problem Class // Find Trailer Problem By Date Match " + Ex.Message);
            }

            return aFindTrailerProblemByDateMatchDataSet;
        }
        public FindTrailerProblemsByDateRangeDataSet FindTrailerProblemsByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindTrailerProblemsByDateRangeDataSet = new FindTrailerProblemsByDateRangeDataSet();
                aFindTrailerProblemsByDateRangeTableAdapter = new FindTrailerProblemsByDateRangeDataSetTableAdapters.FindTrailerProblemsByDateRangeTableAdapter();
                aFindTrailerProblemsByDateRangeTableAdapter.Fill(aFindTrailerProblemsByDateRangeDataSet.FindTrailerProblemsByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailer Problem Class // Find Trailer Problem By Date Range " + Ex.Message);
            }

            return aFindTrailerProblemsByDateRangeDataSet;
        }
        public FindTrailerProblemsByTrailerIDDataSet FindTrailerProblemsByTrailerID(int intTrailerID)
        {
            try
            {
                aFindTrailerProblemsByTrailerIDDataSet = new FindTrailerProblemsByTrailerIDDataSet();
                aFindTrailerProblemsByTrailerIDTableAdapter = new FindTrailerProblemsByTrailerIDDataSetTableAdapters.FindTrailerProblemsByTrailerIDTableAdapter();
                aFindTrailerProblemsByTrailerIDTableAdapter.Fill(aFindTrailerProblemsByTrailerIDDataSet.FindTrailerProblemsByTrailerID, intTrailerID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailer Problem Class // Find Trailer Problems By Trailer ID " + Ex.Message);
            }

            return aFindTrailerProblemsByTrailerIDDataSet;
        }
        public FindOpenTrailerProblemsDataSet FindOpenTrailerProblems()
        {
            try
            {
                aFindOpenTrailerProblemsDataSet = new FindOpenTrailerProblemsDataSet();
                aFindOpenTrailerProblemsTableAdapter = new FindOpenTrailerProblemsDataSetTableAdapters.FindOpenTrailerProblemsTableAdapter();
                aFindOpenTrailerProblemsTableAdapter.Fill(aFindOpenTrailerProblemsDataSet.FindOpenTrailerProblems);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailer Problem Class // Find Open Trailer Problems " + Ex.Message);
            }

            return aFindOpenTrailerProblemsDataSet;
        }
        public bool UpdateTrailerProblemVendor(int intProblemID, int intVendorID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateTrailerProblemVendorTableAdapter = new UpdateTrailerProblemVendorEntryTableAdapters.QueriesTableAdapter();
                aUpdateTrailerProblemVendorTableAdapter.UpdateTrailerProblemVendor(intProblemID, intVendorID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailer Problem Class // Update Trailer Vendor " + Ex.Message);
            }

            return blnFatalError;
        }
        public bool UpdateTrailerProblemSolved(int intProblemID, bool blnProblemSolved)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateTrailerProblemSolvedTableAdapter = new UpdateTrailerProblemSolvedEntryTableAdapters.QueriesTableAdapter();
                aUpdateTrailerProblemSolvedTableAdapter.UpdateTrailerProblemSolved(intProblemID, blnProblemSolved);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailer Problem Class // Update Trailer Problem Solved " + Ex.Message);
            }

            return blnFatalError;
        }
        public bool UpdateTrailerProblemCost(int intProblemID, decimal decProblemCost)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateTrailerProblemCostTableAdapter = new UpdateTrailerProblemCostEntryTableAdapters.QueriesTableAdapter();
                aUpdateTrailerProblemCostTableAdapter.UpdateTrailerProblemCost(intProblemID, decProblemCost);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailer Problem Class // Update Trailer Problem Cost " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertTrailerProblem(int intTrailerID, DateTime datTransactionDate, int intEmployeeID, string strProblemReported, int intVendorID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertTrailerProblemTableAdapter = new InsertTrailerProblemEntryTableAdapters.QueriesTableAdapter();
                aInsertTrailerProblemTableAdapter.InsertTrailerProblem(intTrailerID, datTransactionDate, intEmployeeID, strProblemReported, intVendorID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailer Problem Class // Insert Trailer Problem " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public TrailerProblemDataSet GetTrailerProblemInfo()
        {
            try
            {
                aTrailerProbleDataSet = new TrailerProblemDataSet();
                aTrailerProblemTableAdapter = new TrailerProblemDataSetTableAdapters.trailerproblemTableAdapter();
                aTrailerProblemTableAdapter.Fill(aTrailerProbleDataSet.trailerproblem);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailer Problem Class // Get Trailer Problem Info " + Ex.Message);
            }

            return aTrailerProbleDataSet;
        }
        public void UpdateTrailerProblemDB(TrailerProblemDataSet aTrailerProbleDataSet)
        {
            try
            {
                aTrailerProblemTableAdapter = new TrailerProblemDataSetTableAdapters.trailerproblemTableAdapter();
                aTrailerProblemTableAdapter.Update(aTrailerProbleDataSet.trailerproblem);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailer Problem Class // Update Trailer Problem DB " + Ex.Message);
            }
        }
    }
}
