--SELECT * FROM Stan_odbioru
--GRANT SELECT ON Consignment_Details_View TO Dispatcher;
--GRANT SELECT ON Stan_odbioru TO Dispatcher;
--GRANT INSERT ON Kurs TO Dispatcher;
--GRANT INSERT ON Przesylki_w_kursie TO Dispatcher;
--GRANT INSERT ON Zgloszenia_odbioru TO Dispatcher;
--Revoke INSERT ON Stan_zgloszenia_odbioru TO Dispatcher;
--GRANT SELECT ON Stan_zgloszenia_odbioru TO Dispatcher;
--GRANT UPDATE ON Zgloszenia_odbioru TO Dispatcher;
--GRANT SELECT ON Pickup_Request_List_View To Dispatcher;
--GRANT SELECT ON Course_Details_View To Dispatcher;
--GRANT SELECT ON Consignment_Detailed_List_View To Dispatcher;
--GRANT SELECT ON Przesylki_w_kursie To Dispatcher;
--GRANT SELECT ON Pickup_Request_Map_View TO Dispatcher;

GRANT SELECT ON Course_Details_View TO Courier;
GRANT SELECT ON Course_Consignments_Map_View TO Courier;
GRANT EXEC ON Kursy_kuriera TO Courier
GRANT SELECT ON Consignment_Detailed_List_View To Courier;
GRANT SELECT ON Consignment_Details_View To Courier;
GRANT SELECT ON Przesylki_w_kursie To Courier;
GRANT SELECT ON Przesylka To Courier;
GRANT SELECT ON Parcels_view To Courier;
GRANT SELECT ON Orders_detailed_list_view To Courier;
GRANT SELECT ON Pickup_request_list_view To Courier;

Grant SELECT ON Stan_zgloszenia_odbioru TO Courier;
GRANT SELECT ON Stan_odbioru TO Courier;
GRANT SELECT ON Pickup_Request_Details_View TO Courier;
GRANT SELECT ON Location_Detailed_View TO Courier;
GRANT SELECT ON Pickup_Request_Map_View TO Courier;

GRANT SELECT ON Complaint_Details_View TO CustomerContact;
GRANT UPDATE ON Complaint_Details_View TO CustomerContact;
GRANT SELECT ON Zgloszenia_reklamacji TO CustomerContact;
GRANT UPDATE ON Zgloszenia_reklamacji TO CustomerContact;
GRANT SELECT ON Stan_reklamacji TO CustomerContact;

GRANT SELECT ON Course_Details_View TO CustomerContact;
GRANT SELECT ON Course_Consignments_Map_View TO CustomerContact;
GRANT SELECT ON Consignment_Detailed_List_View To CustomerContact;
GRANT SELECT ON Consignment_Details_View To CustomerContact;
GRANT SELECT ON Przesylki_w_kursie To CustomerContact;
GRANT SELECT ON Przesylka To CustomerContact;
GRANT SELECT ON Parcels_view To CustomerContact;
GRANT SELECT ON Orders_detailed_list_view To CustomerContact;
GRANT SELECT ON Zlecenie To CustomerContact;
GRANT SELECT ON Kurier_1_View To CustomerContact;
GRANT SELECT ON Kurier To CustomerContact;
GRANT SELECT ON Pickup_request_list_view To CustomerContact;

Grant SELECT ON Stan_zgloszenia_odbioru TO CustomerContact;
GRANT SELECT ON Stan_odbioru TO CustomerContact;
GRANT SELECT ON Pickup_Request_Details_View TO CustomerContact;
GRANT SELECT ON Location_Detailed_View TO CustomerContact;
GRANT SELECT ON Pickup_Request_Map_View TO CustomerContact;

GRANT SELECT ON Zgloszenia_odbioru TO CustomerContact;
GRANT INSERT ON Zgloszenia_odbioru TO CustomerContact;
GRANT UPDATE ON Zgloszenia_odbioru TO CustomerContact;

GRANT SELECT ON Zgloszenia_reklamacji TO CustomerContact;
GRANT INSERT ON Zgloszenia_reklamacji TO CustomerContact;
GRANT UPDATE ON Zgloszenia_reklamacji TO CustomerContact;

GRANT SELECT ON Customers_View TO CustomerContact;
GRANT SELECT ON Klient TO CustomerContact;
GRANT INSERT ON Klient TO CustomerContact;

GRANT SELECT ON City_Area_list_View TO CustomerContact;
GRANT SELECT ON Miasto TO CustomerContact;
GRANT SELECT ON Strefa TO CustomerContact;

--OrderManager
GRANT SELECT ON Customers_View To OrderManager;
GRANT SELECT ON Klient To OrderManager;
GRANT SELECT ON Kurier_1_View TO OrderManager;
GRANT SELECT ON Kurier TO OrderManager;

GRANT SELECT ON Orders_detailed_list_View TO OrderManager;
GRANT INSERT ON Zlecenie TO OrderManager;

GRANT SELECT ON Consignment_Detailed_List_View TO OrderManager;
GRANT SELECT ON Consignment_Details_View TO OrderManager;
GRANT SELECT ON Przesylka TO OrderManager;
GRANT INSERT ON Przesylka TO OrderManager;
GRANT UPDATE ON Przesylka TO OrderManager;
GRANT SELECT ON Parcels_View TO OrderManager;
GRANT SELECT ON Paczka TO OrderManager;
GRANT INSERT ON Paczka TO OrderManager;
GRANT UPDATE ON Paczka TO OrderManager;
GRANT SELECT ON Stan_odbioru To OrderManager;

GRANT SELECT ON Cecha To OrderManager;
GRANT SELECT ON Cecha_paczki To OrderManager;
GRANT INSERT ON Cecha_paczki To OrderManager;

GRANT SELECT ON Typ_przesylki To OrderManager;
GRANT SELECT ON Kategoria_wagowa To OrderManager;
GRANT SELECT ON Gabaryty To OrderManager;

GRANT SELECT ON Zgloszenia_odbioru TO OrderManager;
GRANT INSERT ON Zgloszenia_odbioru TO OrderManager;
GRANT UPDATE ON Zgloszenia_odbioru TO OrderManager;

GRANT SELECT ON Pickup_request_list_view To OrderManager;
Grant SELECT ON Stan_zgloszenia_odbioru TO OrderManager;
GRANT SELECT ON Stan_odbioru TO OrderManager;
GRANT SELECT ON Pickup_Request_Details_View TO OrderManager;
GRANT SELECT ON Location_Detailed_View TO OrderManager;
GRANT SELECT ON Pickup_Request_Map_View TO OrderManager;