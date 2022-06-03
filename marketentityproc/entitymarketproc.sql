--elemanekleme prosed�r�
create proc elemanekle(
@elemanadi varchar(50),
@elemanpozisyon varchar(50),
@elemanmaas money,
@elemanstatu varchar(50),
@gorevno int
)
as begin
insert into elemanlar(elemanadi,elemanpozisyon,elemanmaas,elemanstatu,gorevno) values (@elemanadi,@elemanpozisyon,@elemanmaas,@elemanstatu,@gorevno)
end

--elemanlisteleme prosed�r�
create proc elemanlistele
as begin
select * from elemanlar
end

--elemansilme prosed�r�
create proc elemansil
@elemanno int
as begin
delete from elemanlar where elemanno=@elemanno
end

--elemanyenileme prosed�r�
create proc elemanyenile(
@elemanno int,
@elemanadi varchar(50),
@elemanpozisyon varchar(50),
@elemanmaas money,
@elemanstatu varchar(50),
@gorevno int
)
as begin
update elemanlar set
@elemanadi=@elemanadi,elemanadi=@elemanadi,elemanpozisyon=@elemanpozisyon,elemanmaas=@elemanmaas,elemanstatu=@elemanstatu,gorevno=@gorevno
where elemanno=@elemanno
end

--elemanarama prosed�r�
create proc elemanara (
@elemanadi varchar(50)
)
as 
begin
select * from elemanlar where elemanadi=@elemanadi
end


--gorevekleme prosed�r�
create proc gorevekle(
@gorevadi varchar(50),
@gorevtanimi varchar(50),
@gorevfiyat money,
@gorevsuresi varchar(50),
@gorevdurum varchar(50)
)
as begin
insert into gorevler(gorevadi,gorevtanimi,gorevfiyat,gorevsuresi,gorevdurum) values (@gorevadi,@gorevtanimi,@gorevfiyat,@gorevsuresi,@gorevdurum)
end

--g�revlisteleme prosed�r�
create proc gorevlistele
as begin
select * from gorevler
end

--g�revsilme prosed�r�
create proc gorevsil
@gorevno int
as begin
delete from gorevler where gorevno=@gorevno
end

--g�revyenile prosed�r�
create proc gorevyenile(
@gorevno int,
@gorevadi varchar(50),
@gorevtanimi varchar(50),
@gorevfiyat money,
@gorevsuresi varchar(50),
@gorevdurum varchar(50)
)
as begin
update gorevler set
gorevadi=@gorevadi,gorevtanimi=@gorevtanimi,gorevfiyat=@gorevfiyat,gorevsuresi=@gorevsuresi,gorevdurum=@gorevdurum
where gorevno=@gorevno
end

--g�revara prosed�r�
create proc gorevara (
@gorevadi varchar(50)
)
as 
begin
select * from gorevler where gorevadi=@gorevadi
end
