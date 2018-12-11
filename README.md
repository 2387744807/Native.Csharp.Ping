## Native.SDK �ŵ����

> 1. �����ѿ���
> 2. ԭ��c#��������
> 3. ���������QApi
> 4. ֧�ֿ�QӦ�ô��
> 5. ֧�ִ���ֱ�ӵ���

## Native.SDK ��������

>1. Visual Studio 2012 ����߰汾
>2. Microsoft .Net Framework 4.0 **(XPϵͳ֧�ֵ����һ���汾)**

## Native.SDK ��������

	1. ���� Native.Sdk
	2. �� Native.Csharp ��Ŀ����
	3. �޸� ���������е� "Native.Csharp" Ϊ���Լ��� AppId (��: top.jiegg.demo.json)
	4. �޸� ���� -> ���·�� Ϊ��Ŀ�Q app ·��
	4. �ҵ� ������� -> Native.Csharp -> Native.Csharp.json
	5. �޸� �ļ���Ϊ���Լ���Ӧ��ID (��: top.jiegg.demo.json)
	6. �޸� Native.Sharp -> App -> Event -> Event_AppInitialize.cs �е� "AppInfo" �����е� e.AppId Ϊ���Լ��� AppId
	7. ��ʼ��д��Q��� (Ĭ��: Release x86 ���뷽ʽ)

## Native.SDK ��������

	1. �� Native.Csharp ��Ŀ����
	2. �޸� ���� �е� "���·��" Ϊ��� ��Q app Ŀ¼
	3. �޸� ���� -> �������� �е� "�����ⲿ����"  Ϊ��� ��Q ������, ֮�󱣴�
	4. �� ���� -> ѡ�� -> ����, �ر� "Ҫ��Դ�ļ���ԭʼ�汾��ȫƥ��" ��
	5. �޸� Native.Csharp ������ѡ��Ϊ Debug x86
	6. ��ʼ������� ��Q ����

## Native.SDK ��������

  > 1. Native.Csharp �е����� DllExport ���־��� <br />![����](https://raw.githubusercontent.com/Jie2GG/Image_Folder/master/%E9%97%AE%E9%A2%98%E6%88%AA%E5%9B%BE.png "����") <br/>

  * �򿪽��������Ŀ¼ <br /> ![Native��Ŀ¼](https://raw.githubusercontent.com/Jie2GG/Image_Folder/master/Nativc%E6%A0%B9%E7%9B%AE%E5%BD%95.png "���������·��")
  * �򿪽ű��ļ� "DllExport_Configure.bat" <br /> ![�򿪽ű�](https://raw.githubusercontent.com/Jie2GG/Image_Folder/master/Nativc%E8%BF%90%E8%A1%8C%E8%84%9A%E6%9C%AC.png "�򿪽ű�")
  * �鿴�Ƿ�ѡ�� Native.Csharp ��Ŀ, ��ѡ��Ӧ�� <br /> ![Ӧ����Ŀ](https://raw.githubusercontent.com/Jie2GG/Image_Folder/master/%E5%BA%94%E7%94%A8DllExport.png "Ӧ����Ŀ")
  * ѡ�� "ȫ�����¼���" <br /> ![��д����](https://raw.githubusercontent.com/Jie2GG/Image_Folder/master/%E9%97%AE%E9%A2%98%E8%A7%A3%E5%86%B3.png "���¼���")

## Native.SDK ��֪����
	
> 1. ~~���� "EnApi.GetMsgFont" ����, ��ʱ�޷����ݿ�Q�ش���ָ���ȡ������Ϣ, ��ʱ�޷�ʹ��~~ <font color=#FF0000>(���ڿ�Q�������˲���, ����)</font>
> 2. ~~���� "HttpHelper.GetData" ����, �׳��쳣, ��ʱ�޷�ʹ��~~ <font color=#FF0000>(�Ѿ��޸�, ���Ƿ�װ���µ�HTTP��, ����)</font>
> 3. ~~���� "AuthCode" ����������, ����Ӧ��֮�䴮����~~ <font color=#FF0000>(���޸�)</font>

## Native.SDK ������־
> 2018��12��07�� �汾: V2.0.1

  	1. �޸� ��ȡȺ�б���ԶΪ null ��л @kotoneme[https://github.com/kotoneme]
	2. �޸� �Ǽ�������ϵͳ�»�ȡ���ַ���Ϊ�������� ��л @kotoneme[https://github.com/kotoneme]

> 2018��12��06�� �汾: V2.0.0
	
	1. �ع� �����ܴ���
	2. �޸� ����ͬʱ����ʱ "AuthCode" ������Ӧ������
	3. �Ż� �����������, ������Դ�ļ��ϲ�����, ���������������
	4. �Ż� �����������
	5. ���� ��Q������Թ���, ͬʱ֧�� Air/Pro �汾

> 2018��12��05�� �汾: V1.1.2

	1. �޸� HttpWebClient ����

> 2018��12��05�� �汾: V1.1.1

	1. �����޸���Ӧ������ "AuthCode" �ڴ��ַ�ظ������⵼�µ���APIʱ�ᴮӦ�õ�����
	2. �Ż�SDK�����ٶ�

> 2018��12��04�� �汾: V1.1.0

	1. ���ڿ�Q��������Ϣ�����¼��е� "font" ����, SDK�Ѿ������Ƴ�
	2. �޸� HttpHelper �� "GetData" �������׳��쳣
	3. ���� HttpWebClient ��
	4. ���� PUT, DELETE ����ʽ
	5. ���� ���κ�����ʽ�� Cookies �ύ, �ش�, �Զ��ϲ�����
	6. ���� ���κ�����ʽ�� Headers �ύ, �ش�
	7. ���� ���κ�����ʽ�¿��Դ������ڴ�������� WebProxy ����
	8. ���� ���κ�����ʽ�¿��Կ����Ƿ������Ӧ HTTP ���������ض�������, �Լ�Ӧ���ض������
	9. ���� �ɿ��� "POST" ����ʽ�µ� "Content-Type" ��ͷ�Ŀ���, �ﵽ��������

> 2018��11��30�� �汾: V1.0.0

	1. ����ϴ���Ŀ