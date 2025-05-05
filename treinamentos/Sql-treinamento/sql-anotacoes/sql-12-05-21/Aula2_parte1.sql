SELECT *
FROM EMPLOYEES;

SELECT last_name AS "Name"
from EMPLOYEES;

SELECT last_name + job_id AS "Employees"
FROM EMPLOYEES;

SELECT last_name + ' é ' + job_id AS "Employees"
FROM EMPLOYEES;

SELECT department_id
FROM EMPLOYEES;

SELECT DISTINCT department_id
FROM EMPLOYEES;

SELECT department_id
FROM DEPARTMENTS;

SELECT department_id, job_id
FROM EMPLOYEES;

SELECT DISTINCT department_id, job_id
FROM EMPLOYEES;

EXEC sp_help departments;

EXEC sp_help employees;

SELECT employee_id, last_name, job_id, department_id
FROM EMPLOYEES
WHERE department_id = 90;

SELECT employee_id, last_name AS "Name", job_id, department_id
FROM EMPLOYEES
WHERE department_id = 90 AND job_id = 'AD_VP';

SELECT last_name, job_id, department_id
FROM EMPLOYEES
WHERE last_name = 'Whalen';

SELECT last_name, job_id, department_id
FROM EMPLOYEES
WHERE last_name = 'whalen';

SELECT last_name, job_id, department_id
FROM EMPLOYEES
WHERE hire_date = '2005-06-25';

SELECT last_name, salary
FROM EMPLOYEES
WHERE salary <=3000;

SELECT last_name, salary
FROM EMPLOYEES
WHERE salary BETWEEN 2500 AND 3500;

SELECT last_name, salary
FROM EMPLOYEES
WHERE last_name BETWEEN 'King' AND 'Smith';

SELECT last_name, salary, hire_date
FROM EMPLOYEES
WHERE hire_date BETWEEN '2005-06-25' AND '2006-06-25';

SELECT employee_id, last_name, salary, manager_id
FROM EMPLOYEES
WHERE manager_id IN (100, 101, 201);

SELECT employee_id, last_name, salary, manager_id
FROM EMPLOYEES
WHERE last_name IN ('Vargas', 'Hartstein');

SELECT employee_id, last_name, salary, manager_id
FROM EMPLOYEES
WHERE last_name = 'Vargas'
	OR last_name = 'Hartstein';

SELECT first_name
FROM EMPLOYEES
WHERE first_name LIKE '%y';

SELECT last_name, hire_date
FROM EMPLOYEES
WHERE hire_date LIKE '2003%';

SELECT last_name, hire_date, salary
FROM EMPLOYEES
WHERE salary LIKE '2%';

SELECT employee_id, last_name, job_id, salary
FROM EMPLOYEES
WHERE salary >= 10000
AND job_id LIKE '%MAN%';

SELECT employee_id, last_name, job_id, salary
FROM EMPLOYEES
WHERE salary >= 10000
OR job_id LIKE '%MAN%';

SELECT last_name, job_id
FROM EMPLOYEES
WHERE job_id NOT IN ('IT_PROG', 'ST_CLERK', 'SA_REP');

SELECT last_name, job_id, salary
FROM EMPLOYEES
WHERE job_id = 'SA_REP'
OR job_id = 'AD_PRES'
AND salary > 15000;

SELECT last_name, job_id, salary
FROM EMPLOYEES
WHERE (job_id = 'SA_REP'
OR job_id = 'AD_PRES')
AND salary > 15000;

SELECT last_name, job_id, department_id, hire_date 
FROM EMPLOYEES 
ORDER BY hire_date;

SELECT last_name, job_id, department_id, hire_date 
FROM EMPLOYEES 
ORDER BY hire_date, job_id;

SELECT last_name, job_id, department_id, hire_date 
FROM EMPLOYEES 
ORDER BY hire_date DESC;

SELECT last_name, job_id, department_id, hire_date 
FROM EMPLOYEES 
ORDER BY hire_date DESC, job_id ASC;

SELECT getdate(); -- retorna a data atual

SP_HELP EMPLOYEES;

-- INÍCIO DAS "FUNÇÕES DE CARACTER"
SELECT last_name, 
LEN(last_name) 
FROM EMPLOYEES;

SELECT CONCAT(first_name, ' ', last_name) 
FROM EMPLOYEES;

SELECT LOWER (first_name) from EMPLOYEES;

SELECT UPPER (first_name) from EMPLOYEES;

SELECT REPLACE (first_name, 'a', '*') 
FROM EMPLOYEES;

SELECT SUBSTRING(first_name, 1, 3) 
FROM EMPLOYEES;
-- FIM DAS "FUNÇÕES DE CARACTER"


-- INÍCIO DE "DATE FUNCTIONS"
SELECT hire_date, 
DATEADD(YEAR, 1, hire_date)
FROM EMPLOYEES;

SELECT hire_date, 
DATEADD(YEAR, -5, hire_date)
FROM EMPLOYEES;

SELECT hire_date, 
DATEADD(MONTH, 1, hire_date)
FROM EMPLOYEES;

SELECT hire_date,
DATEDIFF (YEAR, hire_date, GETDATE())
FROM EMPLOYEES;

SELECT hire_date,
DATEDIFF (DAY, hire_date, GETDATE())
FROM EMPLOYEES;

SELECT DATEDIFF (MONTH, '1991-08-29', GETDATE())/12; -- retorna a idade da pessoa

SELECT DATEPART(YEAR, hire_date),
hire_date
FROM EMPLOYEES;

SELECT DATEPART(MONTH, hire_date),
hire_date
FROM EMPLOYEES;

SELECT DATEPART(DAY, hire_date),
hire_date
FROM EMPLOYEES;
-- FIM DE "DATE FUNCTIONS"


-- Funções de ***
SELECT AVG(salary) 
FROM EMPLOYEES; --retorna a média dos salários

SELECT SUM(salary) 
FROM EMPLOYEES; --retorna a soma dos salários

SELECT SUM(salary) AS 'Soma dos Salarios',
MIN (salary) AS 'Menor Salario',
MAX (salary) AS 'Maior Salario'
FROM EMPLOYEES;

SELECT COUNT(*) FROM EMPLOYEES;

SELECT COUNT(employee_id) FROM EMPLOYEES;

SELECT department_id,
AVG(salary)
FROM EMPLOYEES
GROUP BY department_id; -- CALCULA A MÉDIA SALARIAL PARA CADA DEPARTAMENTO

SELECT department_id AS 'ID do Departamento',
SUM(salary) AS 'Soma dos Salarios',
MIN (salary) AS 'Menor Salario',
MAX (salary) AS 'Maior Salario'
FROM EMPLOYEES
GROUP BY department_id;

SELECT department_id,
COUNT(*)
FROM EMPLOYEES
GROUP BY department_id; --Retorna numero de funcionarios por departamento

SELECT department_id,
COUNT(*)
FROM EMPLOYEES
GROUP BY department_id
HAVING COUNT(*) > 10; --Retorna apenas departamentos com mais de 10 funcionários

SELECT last_name,
COUNT(*)
FROM EMPLOYEES
GROUP BY last_name
HAVING COUNT(*) > 1;

SELECT last_name,
COUNT(*)
FROM EMPLOYEES
GROUP BY last_name
HAVING LAST_NAME LIKE 'S%' AND COUNT(*) > 1;

