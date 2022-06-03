/*Görev süresi 8 saatten az olanlarý görev durumuna göre sýralayan prosedür*/
create proc gorevsure
as
begin
select gorevdurum as 'Görev süresi 8 saatten az olanlarýn görev durumlarý' from gorevler 
where gorevsuresi<8 group by gorevdurum 
end

/*Maaþý 3500 den fazla olan elemanlarýn görevlerini getiren prosedür*/
create proc gorevmaas
as
begin
select elemanmaas,g.gorevadi  from gorevler g inner join elemanlar e on g.gorevno=e.gorevno
where elemanmaas>3500 
end

/*Statüsü stajyer olanlarýn maaþ ortalamalarýný getiren prosedür */
create proc gorevstatü
as
begin
select sum(elemanmaas) as 'Statüsü stajyer olanlarýn maaþ ortalamalarý'  from elemanlar 
where elemanstatu='stajyer'
end
