   M S B A M L   `   `   `  ���� C  ?TradeLog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TradeLog.ViewTradeLog.View      TradeLog.View.NewUserView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:TradeLog.View       � Title$  NewUserView��$	��600��$	��800�� � WindowStartupLocation$ CenterScreen=�
������  � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � AllowsTransparency .  � Icon$* $/TradeLog;component/Resource/tax.png�� � 	Resources    FocusVisual �� Property �� Value	 J� SnapsToDevicePixels
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
 1000Q��� $��Center=�$��44��$��324,117,301,439q�$
��Wrap=�$��Center=�$	��175��$��Segoe UI Light)�$��28(�$��Új felhasználó���� $��Center=�$��19��$��230,184,511,397q�$
��Wrap=�$��Center=�$��59��$��Segoe UI Light)�$��12(�$��Teljes név *���� $��Center=�$��19��$��231,245,511,336q�$
��Wrap=�$��Center=�$��58��$��Segoe UI Light)�$��12(�$��Login név *���� $��Center=�$��19��$��248,307,511,274q�$
��Wrap=�$��Center=�$��41��$��Segoe UI Light)�$��12(�$��	Jelszó *���� $
��Bold"�$��Center=�$��38��$��220,62,407,500q�$
��Wrap=�$��
P  rtfolio��$��Center=�$	��173��
���   �$��Yu Gothic UI)�$��26(��� $
��Bold"�$��Center=�$��38��$��227,62,400,500q�$
��Wrap=�$	�� o ��$��Center=�$	��173�����	#FFFD5807$��Yu Gothic UI)�$��26(��� $
��Left=�$��517,547,0,0q�$
��Wrap=�$	��Top=�$	��108��$��Calibri Light)��� $�
@TradeLog ���� $� ���� -    ��Name$ version��$� ���� -    ��Name$ 
fullnameBG��$��290,211,280,364q�
�������$ 5��$ 5��$��1��$��Center=�$��Center=�
�������$��25��$	��230�� F� $ 0Q�$
 Gray��$ 0Q�$	 0.2Q��� -   $ loginBG��$��290,271,280,304q�
�������$ 5��$ 5��$��1��$��Center=�$��Center=�
�������$��25��$	��230�� F� $ 0Q�$
 Gray��$ 0Q�$	 0.2Q��� -   $ passBG��$��290,325,280,250q�
�������$ 5��$ 5��$��1��$��Center=�$��Center=�
�������$��25��$	��230�� F� $ 0Q�$
 Gray��$ 0Q�$	 0.2Q��� -    ��Name$ Create��$��Yu Gothic UI Semibold)�$��16(�$��Create��$��Center=�$��34��$��300,396,398,170q�$��Center=�$	��102��#��� 
 �� -   $
 Back��$��Yu Gothic UI Semibold)�$��16(�$
��Back��$��Center=�$��34��$��415,396,283,170q�$��Center=�$	��102��#��� 
 A� -    A�Name$	 sql��
������ $
��Left=�$��10��$��211,550,0,0q�
���   �$	��0.1��$	��Top=�$��10��A� -   $	 xml��
������ $
��Left=�$��10��$��230,550,0,0q�
���   �$	��0.1��$	��Top=�$��10���� -	     ��Name$  fullname��$��Verdana)�$
��Left=�$��20��$��292,215,0,365q�! �� TextWrapping$! NoWrap=�$��Center=�$	��225��
���   �$��0q�
������ �� -
   $  	loginname��$��Verdana)�$
��Left=�$��20��$��292,275,0,305q�$! NoWrap=�$��Center=�$	��225��
���   �$��0q�
������ G� -   " G�Name$" password��$
��Left=�$��292,329,0,0q�$	��Top=�$	��225��
���   �$��0q�$��20��
������ 