   M S B A M L   `   `   `  ????B  >CatsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CatsApp.WindowsCatsApp.Windows  5   	   #    CatsApp.Windows.Authorization   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:CatsApp.Windows     5   	   -   5          ?Name$  authorization??5   	    ? Title$ Котокафе??5   	   $	??450??6   $	??700??6'   $	??450??63   $	??700??6C   .??5	      ? 
??????? ? RowDefinitions 5
   
   ?? 5      ?? 5      ?? 5      .+?5   
   ?? $??0??6   $
??Left=?6   $	??Top=?68   $??
225,72,0,0q?6P   .??6e   Введите логин:6u   ?? 5   
   -   5         ??Name$ LoginTb??5      $??0??6#   $??Bottom=?60   6N   ?? 5   
   $??1??6   $
??Left=?6   $	??Top=?68   $??
225,26,0,0q?6P   .??6e   Введите пароль:6v   ?? 5   
   -   5        $ 
PasswordTb??5      $??1??6&   $??Center=?63   6Q   ?? 5   
   -   5         ??Name$ AuthBtn??5      $??2??6"   $"??Авторизоваться??6/   $	??Top=?6H   6x   ?? 5   
   -   5        $ ToRegBtn??5      $??2??6#   $??Регистрация??60   $??Center=?6F   $??Center=?6h   6?   5      5      