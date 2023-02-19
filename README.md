# back-to-the-future-app
## Что это за программа, кем и для чего сделана
Данный репозиторий создан для AR-приложения, разработанного для изучения фразовых глаголов английского языка, т.е. каждое слово можно будет визуализировать благодаря технолгии Дополненной реальности.
Проект был подготовлен учениками школы №1573 10-х и 9-х классов для Московской предпрофессиональной олимпиады в рамках профиля "Информационные технологии".
В ходе работы использовался следующий стек технологий: игровой движок Unity, интегрированная среда разработки Microsoft Visual Studio, плагины для движка ARFoundation и ARCore, создания 3D моделей велось в Blender 3D. Весь код написан на языке C#.
## Как устроено приложение
### Игровой движок
Настройка игрового движка Unity велась, основываясь на том, что разработка должна быть ориентирована на Android. Для этого из библиотеки ARFoundation использовался именно ARCore. 
### Программный код
Написан отдельно код смены сцен, то есть переход по кнопкам, который осуществляется специальной функцией. 
Вторая часть кода импортирует важные библиотеки для создания AR-приложения на Android, также отвечает за проверку нажатия кнопки, нахождения плоской поверхности в видимости камеры, и не дает появляться одновременно нескольким 3D моделям.
## Запуск приложения
Для запуска приложения на мобильном устройстве с операционной системой Android, необходимо просто установить файл с расширением .apk и весом 23 МБ. На вопрос системы о доверии разработчику нужно ответить положительно. Далее будет вопрос "Установить это приложение?", на который также нужно ответить согласием. В итоге значок приложения будет отображаться на рабочем столе используемого мобильного устройства, на него можно будет нажать и запустить приложение.
Для полного функционирования приложения обязательно нужно разрешить приложению снимать фото и видео, иначе вся суть программы будет утеряна.
