   M S B A M L   `   `   `  ���� C  ?TradeLog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TradeLogTradeLog      TradeLog.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:TradeLog     -     � Title$  
MainWindow��$	��600��$	��800�� � WindowStartupLocation$ CenterScreen=�
������  � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � AllowsTransparency .  � Icon$ Resource/tax.png�� � 	Resources    FocusVisual �� Property �� Value	 J� SnapsToDevicePixels
 �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 RoundedButton �� 
TargetType �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 N     &	 c     &	 x     &	 �     &	 �     &	 �     &	 �     &	 �     &		 �     &	
     7   7  7  7  7  7  7  7  7 	 �� .���  � �� �� .R��� $��2q�	 . #��� ��$��1��$	
 1 2R��� $ 	#FFDDDDDD���� $ 	#FF707070���� $ 	#FFBEE6FD���� $ 	#FF3C7FB1���� $ White���� $ White���� $ 	#FFF4F4F4���� $ 	#FFADB2B5���� $ 	#FF838383���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��
 �   ���  � ��$ 0q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $ border��$ 10��#��z��#��z��#��z��	 . ._��� $ contentPresenter��|�.  #��z��#��z����. #	 z	 #��z�� P�  �@��IsDefaulted . . ��� $ border��# � �� � ��P�  �@J�IsMouseOver . . ��� $ border�� � �� �	#FFFD5807��  � ��
 ������� $ border��8   � ��P�  � �� . . ��� $ border��8   � ���� $ border��8   � ��P�  � {� .  . ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8   � ��.��� .+��� $��10q�
������� �� RadiusX$ 10�� �� RadiusY$ 10��$��5��$��Center=�$��Center=�
�������$	��540��$	��450���� $��25q�
�������$ 5��$ 5��$��1��$��Center=�$��Center=�
�������$	��480��$	��400�� J� BitmapEffect F�  F� 	Direction$ 0Q� F� Color$
 Gray�� F� ShadowDepth$ 0Q� F� Softness$
 1000Q��� $��Center=�$��44��$��280,131,270,425q�$
��Wrap=�$��Center=�$	��250��$��Segoe UI Light)�$��28(�$��Log Book for Trading���� $
��Bold"�$��Center=�$��38��$��220,62,407,500q�$
��Wrap=�$��
P  rtfolio��$��Center=�$	��173��
���   �$��Yu Gothic UI)�$��26(��� $
��Bold"�$��Center=�$��38��$��227,62,400,500q�$
��Wrap=�$	�� o ��$��Center=�$	��173�����	#FFFD5807$��Yu Gothic UI)�$��26(��� $
��Left=�$��20��$��251,213,0,0q�$	��Top=�$��20��$��Resource/user.png���� $
��Left=�$��20��$��251,263,0,0q�$	��Top=�$��20��$��Resource/lock.png���� $
��Left=�$��517,547,0,0q�$
��Wrap=�$	��Top=�$��83��$��Calibri Light)��� $�
@TradeLog ���� $� ���� -    ��Name$ version��$� ���� -    ��Name$ loginbg��$��290,211,280,364q�
�������$ 5��$ 5��$��1��$��Center=�$��Center=�
�������$��25��$	��230�� F� $ 0Q�$
 Gray��$ 0Q�$	 0.2Q��� -   $ passbg��$��290,261,280,314q�
�������$ 5��$ 5��$��1��$��Center=�$��Center=�
�������$��25��$	��230�� F� $ 0Q�$
 Gray��$ 0Q�$	 0.2Q��� -    ��Name$ Login��$��3��$��Yu Gothic UI Semibold)�$��16(�$��Login��$��Center=�$��33��$��352.5,311.5,346.5,255.5q�$��Center=�$	��101��#��� 
 �� -   $ Kilepes��$��4��$��Yu Gothic UI Semibold)�$��16(�$
��Exit��$��Center=�$��33��$��352.5,349.5,346.5,217.5q�$��Center=�$	��101��#��� 
 �� -   $��for new Users click here��$
��Left=�$��39��$��227,491,0,0q�$	��Top=�$	��215��$��Segoe UI Light)�$��16(����� " ��.���  � ��
 �   � �� Triggers P�  �@J�IsMouseOver . . ���  � �� �	#FFFD5807A� -     A�Name$	  sql��
������ $
��Left=�$��10��$��211,550,0,0q�
���   �$	��0.1��$	��Top=�$��10��A� -	   $	  xml��
������ $
��Left=�$��10��$��230,550,0,0q�
���   �$	��0.1��$	��Top=�$��10���� -
   ! ��Name$	! log��$�� ��$
��Left=�$��245,542,0,0q�$	��Top=�
������ $��12(�$	��209��G� -   " G�Name$" password��$��2��$
��Left=�$��292,264,0,0q�$	��Top=�$	��225��
���   �$��0q�$��20��
������ �� -   # ��Name$# 	loginname��$��1��$��Verdana)�$
��Left=�$��20��$��292,215,0,365q�$ �� TextWrapping$$ NoWrap=�$��Center=�$	��225��
���   �$��0q�
������ 