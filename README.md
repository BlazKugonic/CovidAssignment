# CovidAssignment
Welcome to covid assigment

Two available apis:
1. /region/cases (Region,From, To)
  Supported query:
  -region (LJ, CE, KR, NM, KK, KP, MB, MS, NG, PO, SG, ZA)<br />
  -From (date yyyy/mm/dd)<br />
  -To (date yyyy/mm/dd)<br />
  -username(covid)<br />
  -password(2021)
  
 2./region/lastweek:<br />
  -username(covid)<br />
  -password(2021)
  
Apis have some basic API authentication, you need to add username and password to query in request.

Project includes libraries:<br />
  -System.IO<br />
  -CsvHelper<br />
  -Restsharp<br />
