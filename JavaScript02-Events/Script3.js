// JavaScript source code
//console.log(document.body.innerHTML);
let headers = document.body.getElementsByTagName("h1");
let paragraph = document.createElement("p");
paragraph.innerHTML = `��� <strong>${headers[0].innerHTML} &ndash; ��������� ������ ���������</strong>, �����.` +
	`���� ����� �������� �������� <code><strong>append()</strong></code>.`;
//document.body.append(paragraph);	//��������� ������ � ����� ����� ����, � ������, ��������� ������� ����� ����������� ������������.
//document.body.prepend(paragraph);	//��������� ������ � ������ ����, � ������, ��������� ������� ����� ������������ �����������.
//document.body.before(paragraph);	//��������� ������ ����� ����������� ������������.
//document.body.after(paragraph);	//��������� ������ ����� ������������ �����������.

//console.log(document.body.childNodes);
document.body.lastChild.before(paragraph);

let header2 = document.createElement("h2");
header2.innerHTML = paragraph.innerHTML;
paragraph.replaceWith(header2);

let u_list = document.createElement("ul");

for (let i = 0; i < 8; i++) {
	let item = document.createElement("li");
	item.innerHTML = `������� ������ ${i + 1}`;
	u_list.append(item);
}

let headers2 = document.getElementsByTagName("h2");
console.log(headers2);

headers2[0].after(u_list);

//console.log(document.getElementsByTagName("ul")[0].lastChild);

headers2[0].insertAdjacentHTML('beforeend', '<p>���� ����� �������� ��� ������ <strong><code>insertAdjacentHTML</code><strong></p>');
/*
	������� ��� ������ insertAdjacentHTML('����_��������', '���_��������');
	beforebegin - ����� ����������� ������������;
	afterbegin  - ����� ������������ �����������;
	beforeend   - ����� ����������� ������������;
	afterend    - ����� ������������ �����������;
 */

let script = document.getElementsByTagName("script");
let ol_header = document.createElement("h2");
ol_header.innerHTML = "������� ������������ ������ ��� ������ JS:";
script[0].insertAdjacentHTML('beforebegin', ol_header.outerHTML);
let ol = document.createElement("ol");
for (let i = 1; i <= 5; i++) {
	let item = document.createElement("li");
	item.innerHTML = `������� ${i}`;
	ol.insertAdjacentHTML('beforeend', item.outerHTML);
}
script[0].insertAdjacentHTML('beforebegin', ol.outerHTML);
console.log(ol);

let header2_clone = header2.cloneNode(true);
header2_clone.innerHTML = "������������ ��������� (���� ��������� ����������� � <strong><code>header2</code></strong>)";
script[0].insertAdjacentHTML('beforebegin', header2_clone.outerHTML);

let u_list_clone = u_list.cloneNode(true);
for (let i = 0; i < u_list_clone.children.length; i++) {
	u_list_clone.children[i].innerHTML += " CLONE";
}
script[0].insertAdjacentHTML("beforebegin", u_list_clone.outerHTML);


script[0].insertAdjacentText("beforebegin", "��������� ������� �����");
let header_3 = document.createElement("h3");
header_3.innerHTML = "��������� ������� ��� ������ ������� <strong><code>insertAdjacentElement()</code></strong>"
script[0].insertAdjacentElement("beforebegin", header_3);

//let header_3_clone = header_3.cloneNode(true);
//header_3_clone.innerHTML = "�������� ��������� �� ��������:";

//u_list.remove();
for (let i = 0; i < 5; i++) {
	console.log(u_list.children[i]);
	//if (i > 3)
	//	u_list.children[i].remove();
	u_list.lastChild.remove();
}

u_list.tagName = "ol";
u_list.nodeName = "OL";
u_list.localName = "ol";