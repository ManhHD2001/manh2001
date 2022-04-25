create database btl_hsk
use btl_hsk

create table tbl_categoryProduct(
id_categoryProduct int primary key,
name_categoryProduct varchar(50)
)

create table tbl_product(
id_product varchar(10) NOT NULL,
id_categoryProduct int,
name_product varchar(50),
date_create date,
amount int,
price int
)

alter table tbl_product
add constraint PK_tblSanpham primary key(id_product)

alter table tbl_product
add constraint FK_categoryProduct_product foreign key(id_categoryProduct) references tbl_categoryProduct(id_categoryProduct)


create table tbl_user(
id_user varchar(10) NOT NULL primary key,
name_user varchar(50),
birthday date,
address_user varchar(50),
sex varchar(10), 
numberphone varchar(10)
)

create table tbl_order(
id_order varchar(10) NOT NULL primary key,
id_user varchar(10),
date_order date,
total_price int,
)

alter table tbl_order
add constraint FK_user_order foreign key(id_user) references tbl_user(id_user)

create table tbl_detailOrder(
id_detail varchar(10) NOT NULL primary key,
id_order varchar(10),
id_product varchar(10),
amount int,
price int  --- tong thanh tien = amount * price(product)  
)


alter table tbl_detailOrder
add constraint FK_detailOrder_order foreign key(id_order) references tbl_order(id_order)

alter table tbl_detailOrder
add constraint FK_detailOrder_product foreign key(id_product) references tbl_product(id_product)


create table tbl_review(
id_review varchar(10) NOT NULL primary key,
id_user varchar(10),
content varchar(50),
date_review date,
id_product varchar(10)
)

alter table tbl_review
add constraint FK_khachhang_review foreign key(id_user) references tbl_user(id_user)

alter table tbl_review
add constraint FK_product_review foreign key(id_product) references tbl_product(id_product)

create table tbl_admin(
id_admin int primary key,
fullname varchar(50),
name_login varchar(20),
passw varchar(20),
email varchar(20)
)

--- Them du lieu ---

/* ---- tbl_categoryProduct ---- */

insert into tbl_categoryProduct
values(1,'Thuc Pham Xanh')

insert into tbl_categoryProduct
values(2,'Thuc Pham VitaminC')

insert into tbl_categoryProduct
values(3,'Thuc Pham VitaminA')

insert into tbl_categoryProduct
values(4,'Thuc Pham Protein')

select *from tbl_product
select *from tbl_categoryProduct

/* ---- tbl_Product ---- */

insert into tbl_product
values('sp1',1,'Rau Cai','05/10/2000',125,15)

insert into tbl_product
values('sp2',2,'Cam Sanh','11/01/2002',140,40)

insert into tbl_product
values('sp3',3,'Bi Ngo','04/19/2001',90,25)

select *from tbl_product

/* ---- tbl_Order ---- */

select *from tbl_order

insert into tbl_order
values('od1','kh1','11/05/2000');

insert into tbl_order
values('od2','kh3','06/16/2002');

insert into tbl_order
values('od3','kh4','04/25/2001');

select * from tbl_order 


select *from tbl_user
select *from tbl_detailOrder

/* ---- tbl_user ---- */

insert into tbl_user
values('kh1','Nguyen Van Manh','10/01/2001','Hai Duong','Nam','0967121709')

insert into tbl_user
values('kh2','Nguyen Thi Minh','06/02/2003','Thai Binh','Nu','0890451006')

insert into tbl_user
values('kh3','Pham Quang Vinh','09/14/2000','Hai Phong','Nam','0962908636')

insert into tbl_user
values('kh4','Pham Hai Yen','05/25/2002','Bac Giang','Nu','0988367203')


/* ---- tbl_review ---- */

insert into tbl_review
values('dg1','kh1','san pham tot','09/02/2001','sp1')

insert into tbl_review
values('dg2','kh3','san pham tuoi','05/19/2003','sp3')

insert into tbl_review
values('dg3','kh2','san pham an toan','06/26/2002','sp1')

insert into tbl_review
values('dg4','kh4','san pham bi moc','12/06/2000','sp2')

/* ---- tbl_Product ---- */

insert into tbl_adminPosition
values('q1','Quan Ly')

insert into tbl_adminPosition
values('q2','Nhan Vien')

select *from tbl_adminPosition
select *from tbl_admin

/* ---- tao thu tuc ---- */

alter proc them_admin(
@ma_admin int,
@hoten varchar(50),
@tenlogin varchar(20),
@matkhau varchar(20),
@mail varchar(20)
)
as insert into tbl_admin
values(@ma_admin, @hoten, @tenlogin, @matkhau, @mail)

select *from tbl_admin

create proc check_login(
@namelogin varchar(20),
@pass varchar(20)
)
as
begin
if exists(select *from tbl_admin where name_login = @namelogin and passw = @pass)
select 1 as code
else if exists(select *from tbl_admin where name_login = @namelogin and passw != @pass)
select 2 as code
else select 3 as code
end

create proc them_loai(
@id int,
@tenloai varchar(50)
)
as insert into tbl_categoryProduct
values(@id,@tenloai);

create proc xoa_loai(
@id int,
@tenloai varchar(50)
)
as 
delete from tbl_categoryProduct where name_categoryProduct = @tenloai;

create proc check_sp(
@masp varchar(10))
as 
select * from tbl_product where id_product = @masp;

create procedure add_sp(
@masp varchar(10),
@maloai int,
@tensp varchar(50),
@ngaytao date,
@soluong int,
@gia int
)
as insert into tbl_product
values(@masp, @maloai, @tensp, @ngaytao, @soluong, @gia);

create proc capnhat_sp
(@masp varchar(10), @maloai int , @tensp varchar(50), @ngaytao date, @soluong int, @gia int)
as
begin 
	update tbl_product set id_categoryProduct = @maloai, name_product = @tensp, date_create = @ngaytao, amount =@soluong, price=@gia
	where id_product = @masp
end

create proc xoa_sp(
@masp varchar(10))
as 
delete from tbl_product where id_product = @masp

create proc Addkh
@makh varchar(10),
@tenkh varchar(50),
@ns date,
@dchi varchar(50),
@gt varchar(10),
@sdt varchar(10)
as 
insert into tbl_user
values(@makh,@tenkh,@ns,@dchi,@gt,@sdt)


create proc UpdateUser
@makh varchar(10),
@tenkh varchar(50),
@ns date,
@dchi varchar(50),
@gt varchar(10),
@sdt varchar(10)
as
	update tbl_user set name_user=@tenkh, birthday=@ns, address_user=@dchi, sex=@gt, numberphone=@sdt
	where id_user=@makh

create proc AddReviewUser
@madg varchar(10),
@makh varchar(10),
@nddg varchar(50),
@ndg date,
@masp varchar(10)
as 
insert into tbl_review
values(@madg,@makh,@nddg,@ndg,@masp)


create proc UpdateReviewUser
@madg varchar(10),
@makh varchar(10),
@nddg varchar(50),
@ndg date,
@masp varchar(10)
as
	update tbl_review set id_user=@makh,content=@nddg,date_review=@ndg,id_product=@masp
	where id_review=@madg

	select *from tbl_review

create proc select_product_by_category
@tenloai varchar(50)
as 
select
id_product as [Mã sản phẩm],
name_categoryProduct as [Tên loại],
name_product as [Tên sản phẩm],
date_create as [Ngày nhập],
amount as [Số lượng],
price as [Giá tiền]
from tbl_categoryProduct inner join tbl_product on tbl_product.id_categoryProduct = tbl_categoryProduct.id_categoryProduct
where tbl_categoryProduct.name_categoryProduct = @tenloai

exec select_product_by_category @tenloai = 'Thuc Pham Xanh'

create proc Review_by_year(@namtk int)
as
select id_review as[Mã đánh giá],tbl_user.name_user as[Tên khách hàng],
tbl_product.name_product as[Tên sản phẩm],content as[Nội dung đánh giá],date_review as[Ngày đánh giá]
from tbl_review inner join tbl_user on tbl_review.id_user = tbl_user.id_user
inner join tbl_product on tbl_review.id_product = tbl_product.id_product
where year(tbl_review.date_review)=@namtk

exec Review_by_year @namtk=2002

create proc Detail_by_Name(@tenkh varchar(50))
as
select tbl_detailOrder.id_detail as [ID], tbl_detailOrder.id_order as [Order], tbl_order.date_order as [Date Create],
tbl_user.name_user as [Name User], tbl_product.name_product as [Product], tbl_detailOrder.amount as [Amount], tbl_detailOrder.price as [Total Price]
from tbl_detailOrder inner join tbl_order on tbl_detailOrder.id_order = tbl_order.id_order inner join tbl_user
on tbl_order.id_user = tbl_user.id_user inner join tbl_product on tbl_detailOrder.id_product = tbl_product.id_product
where tbl_user.name_user = @tenkh


create proc Detail_by_year(@namtk int)
as
select tbl_detailOrder.id_detail as [ID], tbl_detailOrder.id_order as [Order], tbl_order.date_order as [Date Create],
tbl_user.name_user as [Name User], tbl_product.name_product as [Product], tbl_detailOrder.amount as [Amount], tbl_detailOrder.price as [Total Price]
from tbl_detailOrder inner join tbl_order on tbl_detailOrder.id_order = tbl_order.id_order inner join tbl_user
on tbl_order.id_user = tbl_user.id_user inner join tbl_product on tbl_detailOrder.id_product = tbl_product.id_product
where year(tbl_order.date_order)=@namtk



alter procedure add_dh(
@madh varchar(10),
@makh varchar(10),
@dateorder date,
@sum int,
@mactdh varchar(10),
@masp varchar(10),
@soluong int,
@ttien int
)
as 
begin
if (not exists(select id_order from tbl_order where id_order=@madh))
	insert into tbl_order(id_order, id_user, date_order, total_price)
	values(@madh, @makh, @dateorder, @sum)
	insert into tbl_detailOrder(id_detail, id_order, id_product, amount, price)
	values(@mactdh, @madh, @masp, @soluong, @ttien);
	update tbl_order set total_price = @sum where id_order = @madh
end



alter procedure add_cthd(
@mactdh varchar(10),
@madh varchar(10),
@masp varchar(10),
@soluong int,
@ttien int,
@sum int
)
as 
begin
if exists(select id_order from tbl_order where id_order=@madh)
	insert into tbl_detailOrder(id_detail, id_order, id_product, amount, price)
values(@mactdh, @madh, @masp, @soluong, @ttien)
update tbl_order set total_price = @sum where id_order = @madh
end


select *from tbl_Order
select *from tbl_detailOrder

delete from tbl_order where id_order='od6'

create procedure add_chitietdh(
@mactdh varchar(10),
@madh varchar(10),
@masp varchar(10),
@soluong int,
@ttien int
)
as 
insert into tbl_detailOrder(id_detail, id_order, id_product, amount, price)
values(@mactdh, @madh, @masp, @soluong, @ttien)

alter proc xoa_ctdh(
@madh varchar(10),
@mactdh varchar(10),
@sum int
)
as 
begin
delete from tbl_detailOrder where id_detail = @mactdh
update tbl_Order set total_price = @sum where id_order = @madh
end


create proc capnhat_ctdh
(@mactdh varchar(10), @madh varchar(10) , @masp varchar(10), @soluong int, @ttien int)
as
begin 
	update tbl_detailOrder set id_detail = @mactdh, id_order = @madh, id_product = @masp, amount = @soluong, price = @ttien
	where id_detail = @mactdh
end


select *from tbl_detailOrder
select *from tbl_categoryProduct


/* ----- Tao view ------- */

create view viewCategory
as select id_categoryProduct as [ID], name_categoryProduct as [Category] from tbl_categoryProduct

create view viewProduct 
as select id_product as[ID Product], id_categoryProduct as [ID Category] ,name_product as[Name Product], date_create as [Date], amount as [Amount], price as [Price] from tbl_product

create view viewListUser
as
select id_user as [Mã khách hàng], name_user as [Tên khách hàng], birthday as [Ngày sinh],
address_user as [Địa chỉ], sex as [Giới tính], numberphone as [Số điện thoại] from tbl_user

create view viewListReview
as
select id_review as[Mã đánh giá],tbl_user.name_user as[Tên khách hàng],
tbl_product.name_product as[Tên sản phẩm],content as[Nội dung đánh giá],date_review as[Ngày đánh giá]
from tbl_review inner join tbl_user on tbl_review.id_user = tbl_user.id_user
inner join tbl_product on tbl_review.id_product = tbl_product.id_product


create view viewDetailOrder
as select id_detail as[ID], id_order as[Order], tbl_product.name_product as [Product],
 tbl_detailOrder.amount as [Amount], tbl_detailOrder.price as [Total price] from tbl_detailOrder inner join tbl_product on tbl_detailOrder.id_product = tbl_product.id_product
select * from viewDetailOrder;


select *from viewListReview
select *from viewProduct
select *from tbl_detailOrder
select *from tbl_product
select *from tbl_order
select *from tbl_detailOrder


select *from tbl_review
select *from tbl_product
select *from tbl_user

alter view viewDetailOrderInfor
as
select tbl_detailOrder.id_detail as [ID], tbl_detailOrder.id_order as [Order],tbl_order.date_order as [Date Create],tbl_user.name_user as [Name User],
tbl_product.name_product as [Product], tbl_detailOrder.amount as [Amount], tbl_detailOrder.price as [Total price]
from tbl_detailOrder inner join tbl_product on tbl_detailOrder.id_product = tbl_product.id_product inner join 
tbl_order on tbl_order.id_order = tbl_detailOrder.id_order inner join
tbl_user on tbl_order.id_user = tbl_user.id_user

select *from viewDetailOrderInfor

--select tbl_detailOrder.id_detail as [ID], tbl_detailOrder.id_order as [Order]
-- ,tbl_user.name_user as [Name User],tbl_user.address_user as [Address User], tbl_user.numberphone as [Phone Number], 

delete from viewDetailOrderInfor where ID = 'ct4'

select *from viewDetailOrderInfor where [Order] = 'od1'

select *from tbl_user
select *from tbl_order
select *from tbl_detailOrder

select tbl_detailOrder.id_order, sum(tbl_detailOrder.price) as [Sum] from tbl_detailOrder
group by tbl_detailOrder.id_order