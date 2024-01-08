namespace Challenges.Evaluation;

public class Challenge7Tests
{
    [Fact]
    public void ExtractKustoQueryTest()
    {
        var text = @"""Here is a sample query that can help you 
                    StormEvents 
                    | where StartTime >= datetime(2019-01-01) 
                    | where StartTime < datetime(2020-01-01) 
                    | where State == 'TEXAS' 
                    | where EventType == 'Hail' 
                    | summarize count() by State, EventType 
                    | sort by State asc, EventType asc 
                    | render piechart

                    This query can help you with a piechart that can show the count of events by state and event type.
        """;

        var query = Challenge7.ExtractKustoQueries(text);
        Assert.Single(query);
        Assert.Equal(@"StormEvents 
                    | where StartTime >= datetime(2019-01-01) 
                    | where StartTime < datetime(2020-01-01) 
                    | where State == 'TEXAS' 
                    | where EventType == 'Hail' 
                    | summarize count() by State, EventType 
                    | sort by State asc, EventType asc 
                    | render piechart"
        , query[0]);


        var text2 = @"""There is a possibility that someone figured out something and fixed it and that made this all fine.   Execute: [Web][Desktop][Web(Lens)][Desktop(SAW)] https://someurl/somedatabase    let   _cluster  =  \u0027somecluster\u0027 ;  let   _database  =  \u0027somedatabase\u0027 ;  let   _startTime  =  datetime (2023-10-27T18:45:00Z);  let   _endTime  =  datetime (2023-10-27T18:51:00Z);  let   _siteName  =  \u0027somesiteName\u0027 ;  cluster ( _cluster ). database ( _database ). SomeTable  |  where   Column1   between  ( _startTime  ..  _endTime )  |  where   strlen ( Column2 ) \u0026gt; 0  and   Column2  !=  \u0022None\u0022  |  where   Column2  !=  \u0022GET\u0022  |  where  (( strlen ( mainSite ) \u0026gt; 0  and   Column3   contains   mainSite )  or  ( strlen ( mainSite ) == 0  and   Column3   contains   _mainSiteName ))  | where   Column4   contains   \u0022logs\u0022  |  where   strlen ( Column5 ) \u0026gt; 0  |  project Column1, Column2, Column3.   As we can see something happened with this query. Do you know what is the distance between sun and moon ?""";

        var query2 = Challenge7.ExtractKustoQueries(text2);
        Assert.Single(query2);
        Assert.Equal(@"let   _cluster  =  \u0027somecluster\u0027 ;  let   _database  =  \u0027somedatabase\u0027 ;  let   _startTime  =  datetime (2023-10-27T18:45:00Z);  let   _endTime  =  datetime (2023-10-27T18:51:00Z);  let   _siteName  =  \u0027somesiteName\u0027 ;  cluster ( _cluster ). database ( _database ). SomeTable  |  where   Column1   between  ( _startTime  ..  _endTime )  |  where   strlen ( Column2 ) \u0026gt; 0  and   Column2  !=  \u0022None\u0022  |  where   Column2  !=  \u0022GET\u0022  |  where  (( strlen ( mainSite ) \u0026gt; 0  and   Column3   contains   mainSite )  or  ( strlen ( mainSite ) == 0  and   Column3   contains   _mainSiteName ))  | where   Column4   contains   \u0022logs\u0022  |  where   strlen ( Column5 ) \u0026gt; 0  |  project Column1, Column2, Column3.", query2.First());
    }
}
