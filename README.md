## Native.SDK �ŵ����

> 1. �����ѿ���
> 2. ԭ��c#��������
> 3. ���������QApi
> 4. ֧�ֿ�QӦ�ô��

## Native.SDK ��������

>1. Visual Studio 2012 ����߰汾
>2. Microsoft .Net Framework 4.0 **(XPϵͳ֧�ֵ����һ���汾)**

## Native.SDK ��������

	1. ���� Native.SDK
	2. �� ������� -> Native.Demo -> App.Event -> Event_AppInitialize.cs
	3. �޸� "AppInfo" �����е� e.AppId Ϊ���Լ���Ӧ��ID
	4. �ҵ� ������� -> Native.Demo -> Native.Demo.json
	5. �޸� �ļ���Ϊ���Լ���Ӧ��ID (��: top.jiegg.demo.json)
	6. ��ʼ��д���Ӧ��
	7. ���� Native.Demo ��Ŀ, �ɹ����ҵ�����Ŀ�� bin -> x86 -> Release -> Native.Demo.dll
	8. ��dll�ļ����޸�Ϊ���Լ���Ӧ��ID (��: top.jiegg.demo.dll)
	9. ���Ƶ� ��Q app Ŀ¼

## Native.SDK ��֪����
	
> 1. ~~���� "EnApi.GetMsgFont" ����, ��ʱ�޷����ݿ�Q�ش���ָ���ȡ������Ϣ, ��ʱ�޷�ʹ��~~ (���ڿ�Q�������˲���, ����)
> 2. ~~���� "HttpHelper.GetData" ����, �׳��쳣, ��ʱ�޷�ʹ��~~ (�Ѿ��޸�, ���Ƿ�װ���µ�HTTP��, ����)

## Native.SDK ������־
> 2018��12��01�� �汾: V1.1.0

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