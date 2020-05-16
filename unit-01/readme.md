## unit-01
### управляемый код

16.05.2020  

---  

Концепции:  
* архитектура программного кода
* пространство имён и using
* компиляция без среды разработки
* partial class
* class и new
* class и объект
* перегрузка методов

Практика:  
* оценка времени работы программы
* найти строку в файле: линейный и бинарный поиск



Файл со списком слов русского языка:  
[https://pcoding.ru/txt/words.txt](https://pcoding.ru/txt/words.txt)  

```
загрузим файл:	
new WebClient().DownloadFile(url_file, Path.GetFileName(url_file));
```