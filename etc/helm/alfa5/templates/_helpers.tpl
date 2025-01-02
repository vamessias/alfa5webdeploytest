,
{{- define "alfa5.hosts.webpublic" -}}
{{- print "https://" (.Values.global.hosts.webpublic | replace "[RELEASE_NAME]" .Release.Name) -}}
{{- end -}}
{{- define "alfa5.hosts.httpapi" -}}
{{- print "https://" (.Values.global.hosts.httpapi | replace "[RELEASE_NAME]" .Release.Name) -}}
{{- end -}}
{{- define "alfa5.hosts.blazorwebapp" -}}
{{- print "https://" (.Values.global.hosts.blazorwebapp | replace "[RELEASE_NAME]" .Release.Name) -}}
{{- end -}}
{{- define "alfa5.hosts.authserver" -}}
{{- print "https://" (.Values.global.hosts.authserver | replace "[RELEASE_NAME]" .Release.Name) -}}
{{- end -}}
