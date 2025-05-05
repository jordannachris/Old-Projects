/*
1 - Insira os dados da planilha Atividade 1 nas suas tabelas
2 - Atualize o modelo todos os BMWs para a descrição "Carro caro"
3 - Delete todos os carros da Peugeot
4 - Atualize o modelo de todos os carros da Toyota, Honda e Audi anteriores a 2015 para "carros de tiozão"
*/

SELECT * FROM CLIENTES;

SELECT * FROM CARROS;

insert into CLIENTES (nome,sobrenome,idade,email,endereco,numero,cep)  
values ('Marcos','Borba',20,'marcos.borba@iteris.com.br','Rua A',234,'02214-120');

insert into CLIENTES (nome,sobrenome,idade,email,endereco,numero,cep)  
values ('Eduardo','Vicente',25,'eduardo.vicente@iteris.com.br','Rua B',231,'02354-001');

insert into CLIENTES (nome,sobrenome,idade,email,endereco,numero,cep)  
values ('Haroldo','Medeiros',19,'haroldo.medeiros@iteris.com.br','Rua C',543,'13514-024');

insert into CLIENTES (nome,sobrenome,idade,email,endereco,numero,cep)  
values ('Julio','Guzelotto',36,'julio.guzelotto@iteris.com.br','Rua A',12314,'12345-123');

insert into CLIENTES (nome,sobrenome,idade,email,endereco,numero,cep) 
values ('Luis','Imoto',28,'luis.imoto@iteris.com.br','Rua B',1235,'12352-090');

insert into CLIENTES (nome,sobrenome,idade,email,endereco,numero,cep) 
values ('Rafael','Francisco',34,'rafael.francisco@iteris.com.br','Rua C',65,'24678-221');

insert into CLIENTES (nome,sobrenome,idade,email,endereco,numero,cep) 
values ('Alex','Oshika',37,'alex.oshika@iteris.com.br','Rua A',321,'35552-119');

insert into CLIENTES (nome,sobrenome,idade,email,endereco,numero,cep) 
values ('Juliana','Sandow',41,'juliana.sandow@iteris.com.br','Rua B',32,'23452-234');

insert into CLIENTES (nome,sobrenome,idade,email,endereco,numero,cep) 
values ('Tony','Rodrigues',33,'tony.rodrigues@iteris.com.br','Rua C',4,'13212-534');

insert into CLIENTES (nome,sobrenome,idade,email,endereco,numero,cep) 
values ('Thiago','Boldrin',36,'thiago.boldrin@iteris.com.br','Rua A',66,'45345-766');

insert into CARROS (modelo,marca,ano,versao) values ('Towner Panel Van','Asia Motors',2015,'Towner Panel Van');
insert into CARROS (modelo,marca,ano,versao) values ('A4 2.4 30V Avant Mec','Audi',2017,'A4 2.4 30V Avant Mec');
insert into CARROS (modelo,marca,ano,versao) values ('A6 3.0 Avant V6 30V 218cv Multitronic 5p','Audi',2005,'A6 3.0 Avant V6 30V 218cv Multitronic 5p');
insert into CARROS (modelo,marca,ano,versao) values ('318i/iA Compact 1.8 16V','BMW',2001,'318i/iA Compact 1.8 16V');
insert into CARROS (modelo,marca,ano,versao) values ('528IA High','BMW',1996,'528IA High');
insert into CARROS (modelo,marca,ano,versao) values ('X3 Sport 2.5 24V 192cv','BMW',2007,'X3 Sport 2.5 24V 192cv');
insert into CARROS (modelo,marca,ano,versao) values ('Cirrus LXi 2.5 V6 24V','Chrysler',2002,'Cirrus LXi 2.5 V6 24V');
insert into CARROS (modelo,marca,ano,versao) values ('Xantia 2.0  16V','Citroën',2013,'Xantia 2.0  16V');
insert into CARROS (modelo,marca,ano,versao) values ('Xsara VTS 1.6 16V 3p','Citroën',2011,'Xsara VTS 1.6 16V 3p');
insert into CARROS (modelo,marca,ano,versao) values ('Move Van','Daihatsu',2015,'Move Van');
insert into CARROS (modelo,marca,ano,versao) values ('360 Spider 400cv','Ferrari',1993,'360 Spider 400cv');
insert into CARROS (modelo,marca,ano,versao) values ('Duna 1.6ie','Fiat',2014,'Duna 1.6ie');
insert into CARROS (modelo,marca,ano,versao) values ('Palio 1.0/ Trofeo 1.0 Fire/ Fire Flex 4p','Fiat',1995,'Palio 1.0/ Trofeo 1.0 Fire/ Fire Flex 4p');
insert into CARROS (modelo,marca,ano,versao) values ('Palio EX Century 1.0 mpi Fire 16v 4p','Fiat',1991,'Palio EX Century 1.0 mpi Fire 16v 4p');
insert into CARROS (modelo,marca,ano,versao) values ('CHAMPION 45 100cc','BAJAJ',2010,'CHAMPION 45 100cc');
insert into CARROS (modelo,marca,ano,versao) values ('FIREBOLT XB12 R','BUELL',1998,'FIREBOLT XB12 R');
insert into CARROS (modelo,marca,ano,versao) values ('749','DUCATI',1999,'749 749');
insert into CARROS (modelo,marca,ano,versao) values ('EC 125 ENDUCROSS','GAS GAS',1992,'EC 125 ENDUCROSS');
insert into CARROS (modelo,marca,ano,versao) values ('ROAD KING Classic/ Custom','HARLEY-DAVIDSON',2014,'ROAD KING Classic/ Custom');
insert into CARROS (modelo,marca,ano,versao) values ('CBR 600 F','HONDA',2016,'CBR 600 F');
insert into CARROS (modelo,marca,ano,versao) values ('VALKYRIE 1500','HONDA',2004,'VALKYRIE 1500');
insert into CARROS (modelo,marca,ano,versao) values ('ERO PLUS 125cc','KASINSKI',1996,'ERO PLUS 125cc');
insert into CARROS (modelo,marca,ano,versao) values ('VULCAN VN 1500 CLASSIC/ Mean Streak','KAWASAKI',2013,'VULCAN VN 1500 CLASSIC/ Mean Streak');
insert into CARROS (modelo,marca,ano,versao) values ('QUATTOR 30.0 190cc','LAVRALE',1996,'QUATTOR 30.0 190cc');
insert into CARROS (modelo,marca,ano,versao) values ('VIVACITY 50','PEUGEOT',1990,'VIVACITY 50');
insert into CARROS (modelo,marca,ano,versao) values ('AN 125 Burgman','SUZUKI',1997,'AN 125 Burgman');
insert into CARROS (modelo,marca,ano,versao) values ('CJ 50-F','TRAXX',2005,'CJ 50-F');
insert into CARROS (modelo,marca,ano,versao) values ('BWS 50','YAMAHA',2006,'BWS 50');
insert into CARROS (modelo,marca,ano,versao) values ('YFM 350 GRIZZLY 350cc','YAMAHA',1997,'YFM 350 GRIZZLY 350cc');
insert into CARROS (modelo,marca,ano,versao) values ('Premio CSL 1.6 i.e./ 1.5 4p','Fiat',2012,'Premio CSL 1.6 i.e./ 1.5 4p');
insert into CARROS (modelo,marca,ano,versao) values ('Strada Trekking 1.4 mpi Fire Flex 8V CE','Fiat',1992,'Strada Trekking 1.4 mpi Fire Flex 8V CE');
insert into CARROS (modelo,marca,ano,versao) values ('Uno Mille  ELX  2p e 4p','Fiat',2009,'Uno Mille  ELX  2p e 4p');
insert into CARROS (modelo,marca,ano,versao) values ('Del Rey Belina GL','Ford',2013,'Del Rey Belina GL');
insert into CARROS (modelo,marca,ano,versao) values ('Escort XR3 1.8 / 1.6 Conversível','Ford',2014,'Escort XR3 1.8 / 1.6 Conversível');
insert into CARROS (modelo,marca,ano,versao) values ('F-1000 XLT 2.5 HSD Diesel TB','Ford',2012,'F-1000 XLT 2.5 HSD Diesel TB');
insert into CARROS (modelo,marca,ano,versao) values ('Fiesta GL 1.0 5p','Ford',2013,'Fiesta GL 1.0 5p');
insert into CARROS (modelo,marca,ano,versao) values ('KA Street 1.0i','Ford',1992,'KA Street 1.0i');
insert into CARROS (modelo,marca,ano,versao) values ('Ranger Splash CE','Ford',2012,'Ranger Splash CE');
insert into CARROS (modelo,marca,ano,versao) values ('Ranger XLT 4.0 4x4 CE','Ford',1993,'Ranger XLT 4.0 4x4 CE');
insert into CARROS (modelo,marca,ano,versao) values ('A-20 Custom Std. CD/ De Luxe CD','Chevrolet',1992,'A-20 Custom Std. CD/ De Luxe CD');
insert into CARROS (modelo,marca,ano,versao) values ('Blazer SS-10 4.3 V6','Chevrolet',2001,'Blazer SS-10 4.3 V6');
insert into CARROS (modelo,marca,ano,versao) values ('Chevette L / SL / SL/e / DL / SE 1.6','Chevrolet',2016,'Chevette L / SL / SL/e / DL / SE 1.6');
insert into CARROS (modelo,marca,ano,versao) values ('Corsa Sedan GLS 1.6 MPFI 4p','Chevrolet',1997,'Corsa Sedan GLS 1.6 MPFI 4p');
insert into CARROS (modelo,marca,ano,versao) values ('Kadett GSi 2.0 Conversível','Chevrolet',1996,'Kadett GSi 2.0 Conversível');
insert into CARROS (modelo,marca,ano,versao) values ('S10 Blazer Colina 2.8 TDI 4x4 Diesel','Chevrolet',1999,'S10 Blazer Colina 2.8 TDI 4x4 Diesel');
insert into CARROS (modelo,marca,ano,versao) values ('S10 Pick-Up Std. 2.2 MPFI / EFI','Chevrolet',2016,'S10 Pick-Up Std. 2.2 MPFI / EFI');
insert into CARROS (modelo,marca,ano,versao) values ('Trafic Furgão Carga 2.1 Diesel','Chevrolet',2003,'Trafic Furgão Carga 2.1 Diesel');
insert into CARROS (modelo,marca,ano,versao) values ('BR-800 (todos)/ Supermini','Gurgel',2004,'BR-800 (todos)/ Supermini');
insert into CARROS (modelo,marca,ano,versao) values ('Fit LXL 1.4/ 1.4 Flex 8V 5p Mec.','Honda',2000,'Fit LXL 1.4/ 1.4 Flex 8V 5p Mec.');
insert into CARROS (modelo,marca,ano,versao) values ('H100 GL Furgão Extra-Longo Diesel','Hyundai',1990,'H100 GL Furgão Extra-Longo Diesel');
insert into CARROS (modelo,marca,ano,versao) values ('XJ-8 Executive/ Centenary 4.0','Jaguar',2002,'XJ-8 Executive/ Centenary 4.0');
insert into CARROS (modelo,marca,ano,versao) values ('Bongo K-2700 2.7 4x4 Basculante Diesel','Kia Motors',1993,'Bongo K-2700 2.7 4x4 Basculante Diesel');
insert into CARROS (modelo,marca,ano,versao) values ('Magentis LX 2.0 16V 145cv Aut','Kia Motors',2001,'Magentis LX 2.0 16V 145cv Aut');
insert into CARROS (modelo,marca,ano,versao) values ('Range Rover Sport HSE 4.4 V8 32V 295cv','Land Rover',2019,'Range Rover Sport HSE 4.4 V8 32V 295cv');
insert into CARROS (modelo,marca,ano,versao) values ('Spyder CC 4.2 V8 32V 390cv','Maserati',1996,'Spyder CC 4.2 V8 32V 390cv');
insert into CARROS (modelo,marca,ano,versao) values ('C-180 Kompressor Classic 1.8 16V 143cv','Mercedes-Benz',2015,'C-180 Kompressor Classic 1.8 16V 143cv');
insert into CARROS (modelo,marca,ano,versao) values ('Classe B 200 2.0 Turbo 193cv Aut.','Mercedes-Benz',1996,'Classe B 200 2.0 Turbo 193cv Aut.');
insert into CARROS (modelo,marca,ano,versao) values ('E-430 Avantgarde','Mercedes-Benz',2019,'E-430 Avantgarde');
insert into CARROS (modelo,marca,ano,versao) values ('Sprinter 311 Chassi 2.2 109cv Diesel','Mercedes-Benz',2009,'Sprinter 311 Chassi 2.2 109cv Diesel');
insert into CARROS (modelo,marca,ano,versao) values ('S-63 AMG L 6.3 V8 525cv Aut','Mercedes-Benz',1993,'S-63 AMG L 6.3 V8 525cv Aut');
insert into CARROS (modelo,marca,ano,versao) values ('Lancer Evolut. IX MR 2.0 290cv TB-IC','Mitsubishi',2014,'Lancer Evolut. IX MR 2.0 290cv TB-IC');
insert into CARROS (modelo,marca,ano,versao) values ('Pajero TR4 2.0 16V 131cv 4x4 Mec.','Mitsubishi',2008,'Pajero TR4 2.0 16V 131cv 4x4 Mec.');
insert into CARROS (modelo,marca,ano,versao) values ('Pathfinder LE 4.0 V6 24V 266cv','Nissan',2005,'Pathfinder LE 4.0 V6 24V 266cv');
insert into CARROS (modelo,marca,ano,versao) values ('106 Soleil 1.0 5p','Peugeot',2018,'106 Soleil 1.0 5p');
insert into CARROS (modelo,marca,ano,versao) values ('306 Selection Hatch 1.8 16V','Peugeot',1995,'306 Selection Hatch 1.8 16V');
insert into CARROS (modelo,marca,ano,versao) values ('406 ST/ SVA 2.0 16V Aut','Peugeot',2017,'406 ST/ SVA 2.0 16V Aut');
insert into CARROS (modelo,marca,ano,versao) values ('911 Carrera 4S Coupé-4','Porsche',1994,'911 Carrera 4S Coupé-4');
insert into CARROS (modelo,marca,ano,versao) values ('Clio Authentique 1.0/1.0 Hi-Power 16V 3p','Renault',2003,'Clio Authentique 1.0/1.0 Hi-Power 16V 3p');
insert into CARROS (modelo,marca,ano,versao) values ('Clio Tech Run 1.0 16v 70cv 5p','Renault',1994,'Clio Tech Run 1.0 16v 70cv 5p');
insert into CARROS (modelo,marca,ano,versao) values ('Megane Sedan RXE/Egeus 2.0','Renault',2016,'Megane Sedan RXE/Egeus 2.0');
insert into CARROS (modelo,marca,ano,versao) values ('9000 CD 2.3 Turbo','Saab',1999,'9000 CD 2.3 Turbo');
insert into CARROS (modelo,marca,ano,versao) values ('Impreza GL 4x4 1.8 16V','Subaru',2012,'Impreza GL 4x4 1.8 16V');
insert into CARROS (modelo,marca,ano,versao) values ('Grand Vitara 2.5 V6 5p Aut.','Suzuki',1994,'Grand Vitara 2.5 V6 5p Aut.');
insert into CARROS (modelo,marca,ano,versao) values ('Corolla Fielder SW 1.8 16V Aut.','Toyota',2003,'Corolla Fielder SW 1.8 16V Aut.');
insert into CARROS (modelo,marca,ano,versao) values ('Hilux CS D4-D 4x2 2.5 16V 102cv TB Dies.','Toyota',2011,'Hilux CS D4-D 4x2 2.5 16V 102cv TB Dies.');
insert into CARROS (modelo,marca,ano,versao) values ('850 GLT SW 2.5 20V','Volvo',2006,'850 GLT SW 2.5 20V');
insert into CARROS (modelo,marca,ano,versao) values ('V40 T-4 ARM Aut.','Volvo',1993,'V40 T-4 ARM Aut.');
insert into CARROS (modelo,marca,ano,versao) values ('Gol 1.0 Plus 16v 2p','VolksWagen',2011,'Gol 1.0 Plus 16v 2p');
insert into CARROS (modelo,marca,ano,versao) values ('Gol City 1.6 Mi Total Flex 8V 2p','VolksWagen',1997,'Gol City 1.6 Mi Total Flex 8V 2p');
insert into CARROS (modelo,marca,ano,versao) values ('Golf 2.0 Mec. ( e Black and Silver )','VolksWagen',1995,'Golf 2.0 Mec. ( e Black and Silver )');
insert into CARROS (modelo,marca,ano,versao) values ('Logus GLSi / GLS 2000','VolksWagen',1997,'Logus GLSi / GLS 2000');
insert into CARROS (modelo,marca,ano,versao) values ('Passat 1.8 Aut.','VolksWagen',2016,'Passat 1.8 Aut.');
insert into CARROS (modelo,marca,ano,versao) values ('Quantum 1.8 Mi/ 1.8i','VolksWagen',1995,'Quantum 1.8 Mi/ 1.8i');
insert into CARROS (modelo,marca,ano,versao) values ('Saveiro SPORTLINE 1.8 Mi Total Flex 8V','VolksWagen',2009,'Saveiro SPORTLINE 1.8 Mi Total Flex 8V');
insert into CARROS (modelo,marca,ano,versao) values ('7000 D 2p (diesel)','AGRALE',1998,'7000 D 2p (diesel)');
insert into CARROS (modelo,marca,ano,versao) values ('CARGO 1215 2p (diesel)','FORD',1995,'CARGO 1215 2p (diesel)');
insert into CARROS (modelo,marca,ano,versao) values ('CARGO 1721 T 3-Eixos 2p (diesel)','FORD',1990,'CARGO 1721 T 3-Eixos 2p (diesel)');
insert into CARROS (modelo,marca,ano,versao) values ('F-14000 HD 3-Eixos 2p (diesel)','FORD',2011,'F-14000 HD 3-Eixos 2p (diesel)');
insert into CARROS (modelo,marca,ano,versao) values ('EUROCARGO 120-E15 3-Eixos 2p (diesel)','IVECO',2006,'EUROCARGO 120-E15 3-Eixos 2p (diesel)');
insert into CARROS (modelo,marca,ano,versao) values ('1214 C 2p (diesel)','Mercedes-Benz',1999,'1214 C 2p (diesel)');
insert into CARROS (modelo,marca,ano,versao) values ('709 2p (diesel)','Mercedes-Benz',1993,'709 2p (diesel)');
insert into CARROS (modelo,marca,ano,versao) values ('L-1214 3-Eixos 2p (diesel)','Mercedes-Benz',2010,'L-1214 3-Eixos 2p (diesel)');
insert into CARROS (modelo,marca,ano,versao) values ('L-1630 2p (diesel)','Mercedes-Benz',2002,'L-1630 2p (diesel)');
insert into CARROS (modelo,marca,ano,versao) values ('LS-2635 2p (diesel)','Mercedes-Benz',2002,'LS-2635 2p (diesel)');
insert into CARROS (modelo,marca,ano,versao) values ('T-142 E 450 6x4 2p (diesel)','SAAB-SCANIA',1999,'T-142 E 450 6x4 2p (diesel)');
insert into CARROS (modelo,marca,ano,versao) values ('R-113 H 320 4x2 2p (diesel)','SCANIA',2015,'R-113 H 320 4x2 2p (diesel)');
insert into CARROS (modelo,marca,ano,versao) values ('T-113 H 320 6X2 2p (diesel)','SCANIA',2004,'T-113 H 320 6X2 2p (diesel)');
insert into CARROS (modelo,marca,ano,versao) values ('12-140 3-Eixos 2p (diesel)','VOLKSWAGEN',1992,'12-140 3-Eixos 2p (diesel)');
insert into CARROS (modelo,marca,ano,versao) values ('16-200 3-Eixos 2p (diesel)','VOLKSWAGEN',1991,'16-200 3-Eixos 2p (diesel)');
insert into CARROS (modelo,marca,ano,versao) values ('5-140 E DELIVERY 2p (diesel)','VOLKSWAGEN',2014,'5-140 E DELIVERY 2p (diesel)');
insert into CARROS (modelo,marca,ano,versao) values ('FH-12 380 GLOBETROTTER 4X2 2p (diesel)','VOLVO',2014,'FH-12 380 GLOBETROTTER 4X2 2p (diesel)');
insert into CARROS (modelo,marca,ano,versao) values ('NL-10 280 6X2 2p (diesel)','VOLVO',1998,'NL-10 280 6X2 2p (diesel)');
insert into CARROS (modelo,marca,ano,versao) values ('JAGUAR JT 100','ADLY',2016,'JAGUAR JT 100');

UPDATE CARROS
SET modelo = 'Carro caro'
WHERE marca = 'BMW';

delete from CARROS
where marca = 'Peugeot';


UPDATE CARROS
SET modelo = 'carros de tiozão'
WHERE marca = 'Toyota' AND ano < 2015;

UPDATE CARROS
SET modelo = 'carros de tiozão'
WHERE marca = 'Honda' AND ano < 2015;

UPDATE CARROS
SET modelo = 'carros de tiozão'
WHERE marca = 'Audi' AND ano < 2015;
