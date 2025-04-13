<h1>ИТиП: Информационные технологии и программирование (3 семестр)</h1>
<p>
 <img src="https://img.shields.io/github/last-commit/DaniilKlyukin/ITiP-3" alt="GitHub last commit"><br>
 <img src="https://img.shields.io/github/repo-size/DaniilKlyukin/ITiP-3" alt="GitHub repo size"><br>
 <img src="https://img.shields.io/github/issues/DaniilKlyukin/ITiP-3" alt="GitHub issues">
</p>
 
<p>Репозиторий содержит учебные материалы по курсу "Информационные технологии и программирование" за третий семестр.</p>

<h2>🏗️ Структура и 📚 содержание репозитория</h2>
<div class="md-code-block md-code-block-dark">
<pre>ITiP-3/
├── Лабораторные/     # Лабораторные работы (начинаем на занятии и доделываем дома)
├── Лекции/           # Презентации лекций
├── Практики/         # Практические задания (делаем вместе на занятии, если пропустили - делаем дома)
├── Примеры/          # Примеры приложений, которые могут быть полезны при выполнении ЛР и ПР
└── Билеты/           # Экзаменационные материалы</pre>
</div>

<h2>✅ Требования для допуска и хорошей оценки на экзамене</h2>
<ol start="1">
 <li><p>Сдать <strong>лабораторные работы</strong> до начала аттестации</p></li>
 <li><p><strong>Не иметь пропусков занятий</strong></p>
  <ul>
   <li><p>При наличии пропусков лекций необходимо предоставить на экзамен <strong>конспекты</strong> пропущенных тем</p></li>
  </ul>
 </li>
</ol>

Инструкция по работе с гит есть в [лекции 2](https://github.com/DaniilKlyukin/ITiP-3/blob/master/%D0%9B%D0%B5%D0%BA%D1%86%D0%B8%D0%B8/%D0%98%D0%A2%D0%B8%D0%9F%203%20%D0%BB%D0%B5%D0%BA%202.pptx).

<h2>👨‍🏫 Темы семестра 🚀</h2>
<h3>1. Основы профессиональной разработки</h3>
<ul>
	<li>
		<p>
			<strong>Архитектурные концепции</strong>
		</p>
		<ul>
			<li>
				<p>API: принципы работы и применение</p>
			</li>
			<li>
				<p>Различия: API vs Библиотеки vs Фреймворки</p>
			</li>
		</ul>
	</li>
	<li>
		<p>
			<strong>Система контроля версий</strong>
		</p>
		<ul>
			<li>
				<p>Git: архитектура и workflow</p>
			</li>
			<li>
				<p>Решение конфликтов слияния</p>
			</li>
			<li>
				<p>Работа с GitHub (Pull Requests, Code Review)</p>
			</li>
		</ul>
	</li>
</ul>
<h3>2. Принципы проектирования</h3>
<ul>
	<li>
		<p>
			<strong>SOLID-принципы</strong>
		</p>
		<ul>
			<li>
				<p>Практическое применение каждого принципа</p>
			</li>
			<li>
				<p>Антипаттерны и code smells</p>
			</li>
		</ul>
	</li>
	<li>
		<p>
			<strong>Шаблоны проектирования</strong>
		</p>
		<ul>
			<li>
				<p>Порождающие (Factory, Singleton, Builder)</p>
			</li>
			<li>
				<p>Структурные (Adapter, Composite, Decorator)</p>
			</li>
			<li>
				<p>Поведенческие (Observer, Strategy, Command)</p>
			</li>
		</ul>
	</li>
</ul>
<h3>3. Тестирование и надежность</h3>
<ul>
	<li>
		<p>
			<strong>Теория тестирования</strong>
		</p>
		<ul>
			<li>
				<p>Классификация ошибок (compile-time, runtime, logical)</p>
			</li>
			<li>
				<p>Уровни тестирования (unit, integration, system)</p>
			</li>
		</ul>
	</li>
	<li>
		<p>
			<strong>Практика тестирования</strong>
		</p>
		<ul>
			<li>
				<p>Unit-тестирование с NUnit</p>
			</li>
		</ul>
	</li>
</ul>
<h3>4. Обработка данных и строк</h3>
<ul>
	<li>
		<p>
			<strong>Регулярные выражения</strong>
		</p>
		<ul>
			<li>
				<p>Класс Regex и его методы</p>
			</li>
			<li>
				<p>Валидация данных по шаблонам</p>
			</li>
			<li>
				<p>Поиск и замена с использованием групп</p>
			</li>
		</ul>
	</li>
</ul>
<h3>5. Параллельное программирование</h3>
<ul>
	<li>
		<p>
			<strong>Многопоточность</strong>
		</p>
		<ul>
			<li>
				<p>Thread и ThreadPool (плюсы и минусы)</p>
			</li>
			<li>
				<p>Синхронизация (lock, Monitor, Mutex, Semaphore)</p>
			</li>
		</ul>
	</li>
	<li>
		<p>
			<strong>Современные подходы</strong>
		</p>
		<ul>
			<li>
				<p>Task Parallel Library (TPL)</p>
			</li>
			<li>
				<p>Parallel.For и Parallel.ForEach</p>
			</li>
			<li>
				<p>Отмена операций (CancellationToken)</p>
			</li>
		</ul>
	</li>
</ul>
<h3>6. Асинхронное программирование</h3>
<ul>
	<li>
		<p>
			<strong>Принципы async/await</strong>
		</p>
		<ul>
			<li>
				<p>Возвращаемые типы (Task, Task<span class="ds-markdown-html">&lt;T&gt;</span>, ValueTask)</p>
			</li>
			<li>
				<p>Обработка исключений в асинхронных методах</p>
			</li>
			<li>
				<p>ConfigureAwait и контекст синхронизации</p>
			</li>
		</ul>
	</li>
	<li>
		<p>
			<strong>Паттерны</strong>
		</p>
		<ul>
			<li>
				<p>Ожидание нескольких задач (WhenAll/WhenAny)</p>
			</li>
			<li>
				<p>Троттлинг и бэтчинг запросов</p>
			</li>
		</ul>
	</li>
</ul>
<h3>7. Работа с базами данных</h3>
<ul>
	<li>
		<p>
			<strong>Entity Framework Core</strong>
		</p>
		<ul>
			<li>
				<p>Подходы (Database-first vs Code-first)</p>
			</li>
			<li>
				<p>LINQ to Entities</p>
			</li>
		</ul>
	</li>
	<li>
		<p>
			<strong>Оптимизация</strong>
		</p>
		<ul>
			<li>
				<p>Треккинг vs No-tracking</p>
			</li>
			<li>
				<p>Загрузка связанных данных</p>
			</li>
		</ul>
	</li>
</ul>		
<hr>

<h2>📌 Важная информация</h2>
<ul>
 <li><p>Все материалы регулярно обновляются</p></li>
 <li><p>Рекомендуется следить за обновлениями репозитория</p></li>
 <li><p>Для вопросов и уточнений можно создавать Issues в этом репозитории</p></li>
</ul>

<h2>🛠 Технические требования</h2>
 <ul>
  <li><p>Для работы с кодом: Visual Studio 2019+/Rider/VSCode</p></li>
  <li><p>Для просмотра лекций: PowerPoint или аналоги</p></li>
  <li><p>Для отчётов: Microsoft Word или совместимые редакторы</p></li>
 </ul>
 
<h2>🤝 Как внести вклад</h2>
<p>Если вы хотите дополнить материалы или исправить ошибки:</p>
<ol start="1"><li><p>Сделайте fork репозитория</p></li>
 <li><p>Создайте ветку с вашими изменениями</p></li>
 <li><p>Отправьте pull request</p></li>
</ol>
<hr>
<p>👨‍💻 <strong>Автор:</strong> Даниил Клюкин (Daniil Klyukin)</p>
