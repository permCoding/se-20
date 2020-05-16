goto start
тут многострочный комментарий
это путь к .NET: C:\Windows\Microsoft.NET\Framework\v4.0.30319\
его можно не писать каждый раз когда нужно компилировать программу в консоли, но тогда нужно прописать путь в системе, вот цепочка действий:
Этот компьютер / Свойства / Дополнительные параметры системы / Переменные среды / Системные переменные / Path / Изменить / Создать ... 
и там вставляете путь к папке где и расположен нужный нам файл компилятора csc.exe

после чего можно запускать на компиляцию короче, например:
csc.exe Program.cs



:start

:: C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe Program01.cs

C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe WFA_mouse_move_partial.cs

rem C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe WFA_mouse_move.cs

pause