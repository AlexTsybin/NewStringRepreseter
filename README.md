# NewStringRepresenter
Кросплатформенное мобильное приложение с использованием технологии Xamarin и фреймворка MvvmCross 

# Структура:

StringRepresenter.API - PCL предназначенная для выгрузки информации с сервера и передачи ее на StringRepresenter.Core.

StringRepresenter.Core - PCL предназначенная для обработки полученной информации с сервера и подготовкой этой информации к выводу на экран.

NewStringRepresenter.Droid - проект, написанный с помощью технологии Xamarin.Android и предназначен для отображения информации, полученной от StringRepresenter.Core. 

NewStringRepresenter.Touch - проект, написанный с помощью технологии Xamarin.iOS и предназначен для отображения информации, полученной от StringRepresenter.Core. 
