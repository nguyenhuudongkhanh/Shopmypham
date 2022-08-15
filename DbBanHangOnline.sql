use BanHangOnline
drop table Products
Create table Products
(
	ProductsID INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	ProductsName NVARCHAR(50),
	ShortDesc NVARCHAR(150),--mô tả ngắn
	Description NVARCHAR(150),--mô tả đầy đủ
	CatID INT,--thuộc danh mục nào
	Price int,--giá
	Discount int,--giảm giá
	Thumb NVARCHAR(255),--ảnh đại diện
	Video NVARCHAR(255),
	DateCreated datetime,--ngày tạo
	DateModifiled datetime,--ngày chỉnh sửa
	BestSellers bit,---sản phẩm đc mua nhiều
	HomeFlag bit,---ghim lên trang chủ
	Active bit,--còn bán/ko bán
	Tags NVARCHAR(Max),
	Tiltle NVARCHAR(255),--Loại
	Alias NVARCHAR(255),--tên bí danh
	MetaDesc NVARCHAR(255),--mô tả meta
	MetaKey NVARCHAR(255),--từ khóa
	UnitslnStock int--sp còn trong kho bn cái
)
SET DATEFORMAT DMY
insert into  [dbo].[Products]
values (N'Nước Hoa Dạng Xịt Paleta Perfume 20ml',N'Nước Hoa Dạng Xịt Không Cồn, Mùi Thơm Dịu Nhẹ Tự Nhiên Paleta Perfume 20ml',
'Nước Hoa Dạng Xịt Không Cồn, Mùi Thơm Dịu Nhẹ Tự Nhiên Paleta Perfume là nước hoa thuộc thương hiệu Paleta không còn với thiết kế dạng nắp xịt độc đáo',3,200000,142000,'nuochoaPaleta.jpg',null,
'22/03/2022','23/03/2022',1,1,1,N'Nước hoa',N'Nước hoa',N'Nước hoa',null,null,50);
insert into  [dbo].[Products]
values (N'Nước Tẩy Trang LOreal Micellar',N'Nước Tẩy Trang Làm Sạch Tươi Mát Cho Da Dầu và Nhạy cảm LOreal Micellar Water 3-in-1 Refreshing Even For Sensitive Skin 400ml',
'Nước Tẩy Trang Làm Sạch Tươi Mát 3 In 1 Cho Da Dầu là  nước tẩy trang mang đến các bước tẩy trang, làm sạch, giữ ẩm và dưỡng mềm da ',1,190000,167000,'nuoctaytrangLOreal.jpg',null,
'22/03/2022','23/03/2022',1,1,1,N'Nước tẩy trang',N'Quy trình dưỡng da',N'Tẩy trang',null,null,20);
SET DATEFORMAT DMY
insert into  [dbo].[Products]
values (N'Sữa Tắm Hatomugi Moisturizin',N'Sữa Tắm Dưỡng Ẩm, Trắng Da Chiết Xuất Ý Dĩ Nhật Bản Hatomugi Moisturizing & Washing The Body Soap 800ml',
'Sữa Tắm Dưỡng Ẩm, Trắng Da Chiết Xuất Ý Dĩ Nhật Bản Hatomugi Moisturizing & Washing The Body Soap là sữa tắm thuộc thương hiệu Hatomugi',2,190000,167000,'suatamHatomugi .jpg',null,
'22/03/2022','23/03/2022',1,1,1,N'Chăm sóc cơ thể',N'Sữa tắm',N'Sữa tắm',null,null,20);
Create table Categories --danh mục
(
	CatID INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,--thuộc danh mục nào
	CatName NVARCHAR(255),
	Description NVARCHAR(Max),--mô tả đầy đủ
		 int,--danh mục phân cấp, danh mục cha hoặc con, dựa vào level
	Levels int,--level 0/cha,level 1/con
	Ordering int,--sắp xếp
	Published bit,--bán hoặc k bán
	Thumb NVARCHAR(255),--ảnh
	Tiltle NVARCHAR(255),--loại
	Alias NVARCHAR(255),
	MetaDesc NVARCHAR(255),--mô tả meta
	MetaKey NVARCHAR(255),--từ khóa
	Cover NVARCHAR(255),--banner quảng caos
	schemaMarkup NVARCHAR(Max)
)
insert into[dbo].[Categories]
values (N'Chăm sóc da mặt',N'Loại da thường được xác định bởi di truyền hoặc sự thay đổi hormone nội tiết tố. Một số thói quen hàng ngày và những yếu tố môi trường ô nhiễm, tuổi tác có thể làm da trở nên xấu hơn. Do đó, hiểu rõ về tính chất các loại da sẽ có cách chăm sóc phù hợp và tránh được tình trạng lão hóa.'
,0,0,1,1,'chamsocda.jpg',N'Mỹ phẩm',N'Chăm sóc da',null,null,null,null);
insert into[dbo].[Categories]
values (N'Chăm sóc cơ thể',N'Sức khỏe đóng vai trò vô cùng quan trọng đối với sự sống của con người. Tuy nhiên, không phải ai cũng biết cách tự chăm sóc bản thân. Do vậy, trong bài viết này các chuyên gia của chúng tôi sẽ giúp bạn giải quyết được vấn đề này một cách dễ dàng nhất, trau dồi thêm những bí quyết chăm sóc sức khỏe hiệu quả hơn. '
,0,0,1,1,'chamsoccothe.jpg',N'Mỹ phẩm',N'Chăm sóc da',null,null,null,null);
insert into[dbo].[Categories]
values (N'Nước hoa',N'Nước hoa mang đến những mùi hương quyến rũ cho cả nam và nữ, là đặc trưng của phong cách, cá tính và gu riêng của mỗi người.'
,0,0,1,1,'nuochoa.jpg',N'Mỹ phẩm',N'Nước hoa',null,null,null,null);
Create table Customers --Khách Hàng
(
	CustomersID INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	FullName NVARCHAR(255),
	Birthday datetime,
	Avatar NVARCHAR(255),
	Address NVARCHAR(255),
	Email VARCHAR(150),
	Phone VARCHAR(12),
	LocationID int,--Vị trí khách hàng --tỉnh thành
	District int,--quận huyện
	Ward int,--phường xã
	CreateDate datetime,--ngày tạo tk
	Password NVARCHAR(255),
	Salt nchar(8),--
	LastLogin datetime,
	Active bit--trạng thái

)
drop table Location
Create table Location --vị trí
(
	LocationID int  IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Name NVARCHAR(100),
	Type NVARCHAR(25),
	Slug NVARCHAR(255),
	NameWithType NVARCHAR(255),
	PathWithType NVARCHAR(255),
	ParentCode int,
	Levels int

)

ALTER TABLE Location
  ADD Parent [int] NULL;
Create Table Orders
(	
	OrdersID int  IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	CustomersID INT ,
	OrderDate datetime,--ngày mua
	ShipDate datetime,--ngày ship
	TransactStatusID int,--trạng thái đơn hàng(đơn hàng mới,đơn hàng đang chuẩn bị, đơn hàng giao)
	Deleted bit,--hủy đơn hàng
	Paid bit,--thanh toán chưa
	PaymentDate datetime,--ngày thanh toán
	PaymentID int,---kiểu thanh toán(momo, ngâng hàng...)
	Note NVARCHAR(Max)--ghi chú cho đơn hàng
	
)

select * from Orders
ALTER TABLE Orders
  ADD Address nvarchar(max) NULL;
ALTER TABLE Orders
  ADD Price int NULL;

ALTER TABLE OrdersDetails
  ADD Amount int NULL;
ALTER TABLE OrdersDetails
  ADD Price int NULL;
ALTER TABLE OrdersDetails
  ADD CreateDate datetime NULL;
Create Table OrdersDetails --chi tiết đơn hàng
(
	OrdersDetailsID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	OrdersID int,
	ProductsID INT,
	OrderNumber int,--số lượng order
	Quantity int,--số lượng sản phẩm
	Discount int,
	Total int,--tổng
	ShipDate datetime
	
)
select * from OrdersDetails
Create Table Pages --thông báo
(

	Pages int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	PageName 	NVARCHAR(255),
	Contents NVARCHAR(Max),
	Thumb NVARCHAR(255),
	Pusblished bit,
	Title NVARCHAR(255),
	MetaDesc NVARCHAR(255),
	MetaKey NVARCHAR(255),
	Alias NVARCHAR(255),
	CreatedDate datetime,
	Ordering int --sắp xếp
)
Create Table Roles--quản lý quyền truy cập
(
	RoleID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	RoleName NVARCHAR(50),
	Description NVARCHAR(55)
)
Create Table Shippers
(

	 ShipperID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	 ShipperName  NVARCHAR(255),
	 Phone  NCHAR(20),
	 Company  NVARCHAR(255),
	 ShipDate datetime
)

Create Table News
(

	PostID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Tiltle  NVARCHAR(255),
	SContents NVARCHAR(255),--mô tả ngắng
	Contents  NVARCHAR(255),--mô tả đầy đủ
	Thumb  NVARCHAR(255),
	Published bit,
	Alias  NVARCHAR(255),
	CreteDate datetime,
	Author  NVARCHAR(255),--tác giả
	AccountID int,
	Tags  NVARCHAR(Max),
	CatID int,
	isHot bit,
	isNewfedd bit,
	MetaKey  NVARCHAR(255),
	MetaDesc  NVARCHAR(255),
	Views  int
)
Create Table TransactStatus--trạng thái đơn hàng
(
	TransactStatusID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Status NVARCHAR(255),
	Description NVARCHAR(Max),--mô tả đầy đủ
)
Create Table Accounts
(
	AccountID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Phone varchar(20),
	Email nvarchar (150),
	Password nvarchar (150),
	Salt nchar(6),
	Active bit,
	FullName nvarchar (150),
	RoleID int,
	LastLogin datetime,
	CreateDate datetime

)
Create Table Atrributes --thuộc tính
(
	AtrributeID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Name nvarchar (150)

)
drop table AtrributesPrices
Create Table AtrributesPrices
(
	AtrributesPriceID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	AtrributeID int,
	ProductsID int,
	Price int,
	Active bit
)
Create table Payment
(
    PaymentID int NOT NULL PRIMARY KEY,
	Status NVARCHAR(255),
	Description NVARCHAR(Max),--mô tả đầy đủ
)

ALTER TABLE[dbo].[OrdersDetails]
ADD CONSTRAINT FK_OrdersDetails_Orders FOREIGN KEY ([OrdersID]) REFERENCES [dbo].[Orders]([OrdersID])

ALTER TABLE [dbo].[News]
ADD CONSTRAINT FK_News_Orders FOREIGN KEY (CatID) REFERENCES [dbo].[Categories](CatID)

ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT FK_Orders_TransactStatus FOREIGN KEY ([TransactStatusID]) REFERENCES [dbo].[TransactStatus]([TransactStatusID])

ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT FK_Orders_Payment FOREIGN KEY ([PaymentID]) REFERENCES [dbo].[Payment]([PaymentID])

ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT FK_Orders_Customers FOREIGN KEY ([CustomersID]) REFERENCES [dbo].[Customers]([CustomersID])


ALTER TABLE [dbo].[Products]
ADD CONSTRAINT FK_Products_Categories FOREIGN KEY ([CatID]) REFERENCES [dbo].[Categories]([CatID])


ALTER TABLE [dbo].[Accounts]
ADD CONSTRAINT FK_Accounts_Roles FOREIGN KEY ([RoleID]) REFERENCES [dbo].[Roles]([RoleID])


ALTER TABLE [dbo].[AtrributesPrices]
ADD CONSTRAINT FK_AtrributesPrices_Atrribute FOREIGN KEY ([AtrributeID]) REFERENCES [dbo].[Atrributes]([AtrributeID])

ALTER TABLE [dbo].[AtrributesPrices]
ADD CONSTRAINT FK_AtrributesPrices_Products FOREIGN KEY ([ProductsID]) REFERENCES [dbo].[Products]([ProductsID])

ALTER TABLE [dbo].[OrdersDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([ProductsID])
REFERENCES [dbo].[Products] ([ProductsID])
insert into Roles
values
('Admin','Admin'),
('Staff',N'Nhân Viên');
select * from Orders
select * from TransactStatus
insert into TransactStatus
values
(N'Chờ lấy hàng',N'Đã xác nhận và đang soạn hàng'),
(N'Chờ xác nhận',N'Đang được người bán xác nhận với người mua'),
(N'Đang giao',N'Đơn hàng đang được giao'),
(N'Đã giao hàng thành công',N'Đơn hàng đã được giao thành công đến người mua'),
(N'Đã hủy',N'Đơn hàng đã được hủy thành công'),
(N'Trả hàng',N'Đơn hàng đã được trả thành công');

insert into Payment
values
(1,N'MOMO',N'Thanh toán bằng MoMo'),
(2,N'Trả tiền mặt',N'Thanh toán trả tiền mặt'),
(3,N'Chuyển khoảng ngân hàng',N'Thanh toán bằng chuyển khoảng');


