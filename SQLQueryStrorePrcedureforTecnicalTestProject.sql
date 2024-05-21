USE [TecnicalDb]
GO

/****** Object:  StoredProcedure [dbo].[GetCorporateCustomers]    Script Date: 5/21/2024 4:38:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetCorporateCustomers]
AS
BEGIN
    SELECT  c.Id
           ,c.Name
           ,c.CustomerTypeId
    FROM Corporate_Customer_Tbl c
END

GO




USE [TecnicalDb]
GO

/****** Object:  StoredProcedure [dbo].[GetCustomerTypes]    Script Date: 5/21/2024 4:38:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetCustomerTypes]
AS
BEGIN
SELECT C.Id, C.Name
FROM Customer_Type_Tbl C
END
GO



USE [TecnicalDb]
GO

/****** Object:  StoredProcedure [dbo].[GetIndividualCustomers]    Script Date: 5/21/2024 4:39:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetIndividualCustomers]
AS
BEGIN
SELECT I.ID,I.NAME,I.CUSTOMERTYPEID
FROM Individual_Customer_Tbl I
END
GO


USE [TecnicalDb]
GO

/****** Object:  StoredProcedure [dbo].[GetPRODUCTSERVICES]    Script Date: 5/21/2024 4:39:42 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetPRODUCTSERVICES]
AS
BEGIN
SELECT P.ID,P.NAME,P.Unit
FROM Products_Service_Tbl P
END
GO


USE [TecnicalDb]
GO

/****** Object:  StoredProcedure [dbo].[GetProuctServiceList]    Script Date: 5/21/2024 4:39:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetProuctServiceList]
AS
BEGIN
SELECT M.Id, P.Name, P.Unit,M.Quantity, MeetingMinutesMasterId FROM Meeting_Minutes_Details_Tbl M
JOIN Products_Service_Tbl P ON P.Id = M.ProductsServiceId
END
GO


USE [TecnicalDb]
GO

/****** Object:  StoredProcedure [dbo].[Meeting_Minutes_Details_Save_SP]    Script Date: 5/21/2024 4:40:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Meeting_Minutes_Details_Save_SP]
    @Quantity int,
	@ProductsServiceId int,
    @MeetingMinutesMasterId int
	
AS
BEGIN
    SET NOCOUNT ON;
	INSERT INTO Meeting_Minutes_Details_Tbl(Quantity,ProductsServiceId,MeetingMinutesMasterId)  
	VALUES (@Quantity,@ProductsServiceId,@MeetingMinutesMasterId);
END;
GO




USE [TecnicalDb]
GO

/****** Object:  StoredProcedure [dbo].[Meeting_Minutes_Master_Save_SP]    Script Date: 5/21/2024 4:40:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Meeting_Minutes_Master_Save_SP]
    @MeetingDate DATE,
	@MeetingTime TIME,
    @Place NVARCHAR(200),
	@ClientSide NVARCHAR(1000),
	@HostSide NVARCHAR(1000),
	@Agenda NVARCHAR(1000),
	@Discussion NVARCHAR(1000),
	@Decision NVARCHAR(1000),
	@CustomerTypeId int,
	@IndividualCustomerId int,
	@CorporateCustomerId int,
    @NewId INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
	INSERT INTO Meeting_Minutes_Master_Tbl(MeetingDate,MeetingTime,Place,ClientSide,HostSide ,Agenda,Discussion,Decision,CustomerTypeId,IndividualCustomerId,CorporateCustomerId)  
	VALUES (@MeetingDate,@MeetingTime,@Place,@ClientSide,@HostSide ,@Agenda,@Discussion,@Decision,@CustomerTypeId,@IndividualCustomerId,@CorporateCustomerId);
    SET @NewId = SCOPE_IDENTITY();
END;
GO


