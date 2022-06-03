/*G�rev s�resi 8 saatten az olanlar� g�rev durumuna g�re s�ralayan prosed�r*/
create proc gorevsure
as
begin
select gorevdurum as 'G�rev s�resi 8 saatten az olanlar�n g�rev durumlar�' from gorevler 
where gorevsuresi<8 group by gorevdurum 
end

/*Maa�� 3500 den fazla olan elemanlar�n g�revlerini getiren prosed�r*/
create proc gorevmaas
as
begin
select elemanmaas,g.gorevadi  from gorevler g inner join elemanlar e on g.gorevno=e.gorevno
where elemanmaas>3500 
end

/*Stat�s� stajyer olanlar�n maa� ortalamalar�n� getiren prosed�r */
create proc gorevstat�
as
begin
select sum(elemanmaas) as 'Stat�s� stajyer olanlar�n maa� ortalamalar�'  from elemanlar 
where elemanstatu='stajyer'
end
